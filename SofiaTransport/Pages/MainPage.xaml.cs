using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using HtmlAgilityPack;
using System.Text;
using SofiaTransport.Models;
using Windows.Storage;
using Windows.UI.ApplicationSettings;
using Windows.UI.Popups;
using Windows.Devices.Sensors;
using Windows.UI.Core;
using Windows.ApplicationModel.DataTransfer;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SofiaTransport
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        TypeModel type;
        BusModel bus;
        DirectionModel direction;
        StopModel stop;
        ObservableCollection<RoamingModel> favStops = new ObservableCollection<RoamingModel>();
        ObservableCollection<RoamingModel> lastStops = new ObservableCollection<RoamingModel>();
        RoamingModel lastStop;
        Accelerometer accelerometer;

        public MainPage()
        {
            //ApplicationData.Current.LocalSettings.Values.Clear();
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            SettingsPane.GetForCurrentView().CommandsRequested += SettingCharmManagerCommandsRequested;
            object countFav = ApplicationData.Current.RoamingSettings.Values["favStopsCount"];

            if (countFav != null && (int)countFav != 0)
            {
                for (int i = 1; i <= (int)countFav; i++)
                {
                    RoamingModel test = new RoamingModel()
                        {
                            Uri = ApplicationData.Current.RoamingSettings.Values["Uri" + i.ToString()].ToString(),
                            Name = ApplicationData.Current.RoamingSettings.Values["Name" + i.ToString()].ToString(),
                            Direction = ApplicationData.Current.RoamingSettings.Values["Direction" + i.ToString()].ToString()

                        };
                    favStops.Add(test);
                }
                FavoritesListBox.ItemsSource = favStops;
            }
            else
            {
                ApplicationData.Current.RoamingSettings.Values["favStopsCount"] = 0;
            }

            object countLast = ApplicationData.Current.LocalSettings.Values["lastStopsCount"];
            if (countLast != null && (int)countLast != 0)
            {
                for (int i = 1; i <= (int)countLast; i++)
                {
                    RoamingModel test = new RoamingModel()
                    {
                        Uri = ApplicationData.Current.LocalSettings.Values["lastUri" + i.ToString()].ToString(),
                        Name = ApplicationData.Current.LocalSettings.Values["lastName" + i.ToString()].ToString(),
                        Direction = ApplicationData.Current.LocalSettings.Values["lastDirection" + i.ToString()].ToString()

                    };
                    lastStops.Add(test);
                }
                LastSearchesListBox.ItemsSource = lastStops.Reverse();
            }
            else
            {
                ApplicationData.Current.LocalSettings.Values["lastStopsCount"] = 0;
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            accelerometer = Accelerometer.GetDefault();
            if (accelerometer != null)
            {
                accelerometer.Shaken += accelerometerShaken;
            }
        }

        async void accelerometerShaken(Accelerometer sender, AccelerometerShakenEventArgs args)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                GetStopByUri(lastStop.Uri);
            });
        }

        private void SettingCharmManagerCommandsRequested(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
        {
            args.Request.ApplicationCommands.Add(new SettingsCommand("privacypolicy", "Privacy policy", OpenPrivacyPolicy));
        }

        private async void OpenPrivacyPolicy(IUICommand command)
        {
            Uri uri = new Uri("http://outernetnotes.com/SofiaTransportPrivacy.html");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void OnTypesComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            type = Types.SelectedItem as TypeModel;
            BusNumbers.ItemsSource = type.Buses;
            Direction.ItemsSource = null;
            Stop.ItemsSource = null;
        }

        private void OnBusNumbersComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BusNumbers.SelectedItem != null)
            {

                bus = BusNumbers.SelectedItem as BusModel;
                Direction.ItemsSource = bus.Directions;
                Stop.ItemsSource = null;
            }
        }

        private void OnDirectionComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Direction.SelectedItem != null)
            {
                direction = Direction.SelectedItem as DirectionModel;
                Stop.ItemsSource = direction.Stops;
            }
        }

        private void OnStopComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Stop.SelectedItem != null)
            {
                stop = Stop.SelectedItem as StopModel;
                string s = stop.s;
                string lid = bus.lid;
                string rid = direction.rid;
                string vt = type.ID.ToString();

                GetStopByParameters(s, lid, vt, rid);
            }
        }

        void GetStopByParameters(string s, string lid, string vt, string rid)
        {
            string requestUri = "vehicle-vt?s=" + s + "&lid=" + lid + "&vt=" + vt + "&rid=" + rid;
            GetStopByUri(requestUri);
            AddToLastSearched();
        }

        async void GetStopByUri(string Uri)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://m.sofiatraffic.bg/schedules/");
                var response = await client.GetAsync(Uri);
                var responseText = await response.Content.ReadAsStringAsync();

                StringBuilder result = new StringBuilder();
                ObservableCollection<ResultModel> resultList = new ObservableCollection<ResultModel>();
                string stop = responseText.Substring(responseText.IndexOf("Спирка (код):") + 20, responseText.IndexOf("Направлениe:") - responseText.IndexOf("Спирка (код):") - 35);
                result.Append("Спирка (код): ");
                result.Append(stop);
                result.Append("\n");
                string direction = responseText.Substring(responseText.IndexOf("Направлениe:") + 27, responseText.IndexOf("Информация") - responseText.IndexOf("Направлениe:") - 73);
                result.Append("Направлениe:");
                result.Append(direction);
                result.Append("\n");
                string time = responseText.Substring(responseText.IndexOf("Информация") + 15, 16);
                result.Append("Информация към ");
                result.Append(time);

                string firstBusNumber = responseText.Substring(responseText.IndexOf("page_title") + 25, 4);
                while (true)
                {
                    if (firstBusNumber[0] == ' ' || firstBusNumber[0] == 'у' || firstBusNumber[0] == 'с')
                    {
                        firstBusNumber = firstBusNumber.Remove(0, 1);
                    }
                    else break;
                }
                while (true)
                {
                    if (firstBusNumber[firstBusNumber.Length - 1] == '<' || firstBusNumber[firstBusNumber.Length - 1] == '/' || firstBusNumber[firstBusNumber.Length - 1] == 'b')
                    {
                        firstBusNumber = firstBusNumber.Remove(firstBusNumber.Length - 1, 1);
                    }
                    else break;
                }
                string firstBus = responseText.Substring(responseText.IndexOf("пристигане") + 24, 17);
                if(firstBus[0]=='<') firstBus="Няма информация";
                resultList.Add(new ResultModel
                {
                    Time = firstBus,
                    Number = firstBusNumber
                });

                List<char> numbers = new List<char>{'0','1','2','3','4','5','6','7','8','9'};
                if (responseText.IndexOf("Автобуси") != -1)
                {
                    int start = responseText.IndexOf("arr_info_1");
                    while (start != -1)
                    {
                        string bus = responseText.Substring(start + 90, 3);
                        if (bus[2] == '<' || bus[2] == '/') bus = bus.Remove(2, 1);
                        if (bus[1] == '<') bus = bus.Remove(1, 1);
                        string busTime = responseText.Substring(start + 115, 20);
                        while (!numbers.Contains(busTime[busTime.Length - 1]))
                        {
                            busTime= busTime.Remove(busTime.Length - 1, 1);
                        }
                        while (!numbers.Contains(busTime[0]))
                        {
                            busTime = busTime.Remove(0, 1);
                        }
                        resultList.Add(new ResultModel
                        {
                            Number = bus,
                            Time = busTime
                        });
                        start = responseText.IndexOf("arr_info_1", start + 1);
                    }
                }

                if (responseText.IndexOf("Тролейбуси") != -1)
                {
                    int start = responseText.IndexOf("arr_info_2");
                    while (start != -1)
                    {
                        string bus = responseText.Substring(start + 90, 3);
                        if (bus[2] == '<' || bus[2] == '/') bus = bus.Remove(2, 1);
                        if (bus[1] == '<') bus = bus.Remove(1, 1);
                        while (true)
                        {
                            if (bus[bus.Length - 1] == '<' || bus[bus.Length - 1] == '/') bus = bus.Remove(bus.Length - 1, 1);
                            else break;
                        }
                        string busTime = responseText.Substring(start + 115, 20);
                        while (!numbers.Contains(busTime[busTime.Length - 1]))
                        {
                            busTime = busTime.Remove(busTime.Length - 1, 1);
                        }
                        while (!numbers.Contains(busTime[0]))
                        {
                            busTime = busTime.Remove(0, 1);
                        }
                        resultList.Add(new ResultModel
                        {
                            Number = bus,
                            Time = busTime
                        });
                        start = responseText.IndexOf("arr_info_2", start + 1);
                    }
                }
                if (responseText.IndexOf("Трамваи") != -1)
                {
                    int start = responseText.IndexOf("arr_info_3");
                    while (start != -1)
                    {
                        string bus = responseText.Substring(start + 90, 3);
                        while (true)
                        {
                            if (bus[bus.Length - 1] == '<' || bus[bus.Length - 1] == '/') bus = bus.Remove(bus.Length - 1, 1);
                            else break;
                        }
                        string busTime = responseText.Substring(start + 115, 20);
                        while (!numbers.Contains(busTime[busTime.Length - 1]))
                        {
                            busTime = busTime.Remove(busTime.Length - 1, 1);
                        }
                        while (!numbers.Contains(busTime[0]))
                        {
                            busTime = busTime.Remove(0, 1);
                        }
                        resultList.Add(new ResultModel
                        {
                            Number = bus,
                            Time = busTime
                        });
                        start = responseText.IndexOf("arr_info_3", start + 1);
                    }
                }
                Posts.Text = result.ToString();
                ResultsListBox.ItemsSource = resultList;
                
            }
            catch (Exception)
            {
                Posts.Text = "Няма намерена информация";
                ResultsListBox.ItemsSource = null;
            }
        }

        private void AddToLastSearched()
        {
            if (stop != null)
            {
                string s = stop.s;
                string lid = bus.lid;
                string rid = direction.rid;
                string vt = type.ID.ToString();
                lastStop = new RoamingModel()
                {
                    Uri = "vehicle-vt?s=" + s + "&lid=" + lid + "&vt=" + vt + "&rid=" + rid,
                    Name = stop.Name,
                    Direction = direction.Name
                };
                int currCount = (int)ApplicationData.Current.LocalSettings.Values["lastStopsCount"];
                currCount++;
                ApplicationData.Current.LocalSettings.Values["lastStopsCount"] = currCount;
                lastStops.Add(lastStop);
                LastSearchesListBox.ItemsSource = lastStops.Reverse();

                ApplicationData.Current.LocalSettings.Values["lastUri" + currCount.ToString()] = lastStop.Uri;
                ApplicationData.Current.LocalSettings.Values["lastName" + currCount.ToString()] = lastStop.Name;
                ApplicationData.Current.LocalSettings.Values["lastDirection" + currCount.ToString()] = lastStop.Direction;
            }
        }
        private void SaveFavouritesButtonClick(object sender, RoutedEventArgs e)
        {
            if (stop != null)
            {
                string s = stop.s;
                string lid = bus.lid;
                string rid = direction.rid;
                string vt = type.ID.ToString();
                RoamingModel newStop = new RoamingModel()
                {
                    Uri = "vehicle-vt?s=" + s + "&lid=" + lid + "&vt=" + vt + "&rid=" + rid,
                    Name = stop.Name,
                    Direction = direction.Name
                };
                int currCount = (int)ApplicationData.Current.RoamingSettings.Values["favStopsCount"];
                currCount++;
                ApplicationData.Current.RoamingSettings.Values["favStopsCount"] = currCount;
                favStops.Add(newStop);
                FavoritesListBox.ItemsSource = favStops;

                ApplicationData.Current.RoamingSettings.Values["Uri" + currCount.ToString()] = newStop.Uri;
                ApplicationData.Current.RoamingSettings.Values["Name" + currCount.ToString()] = newStop.Name;
                ApplicationData.Current.RoamingSettings.Values["Direction" + currCount.ToString()] = newStop.Direction;
            }
            else
            {

            }
        }



        private void FavoritesListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FavoritesListBox.SelectedItem != null)
            {
                GetStopByUri((FavoritesListBox.SelectedItem as RoamingModel).Uri);
            }
        }

        private void LastSearchesListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LastSearchesListBox.SelectedItem != null)
            {
                GetStopByUri((LastSearchesListBox.SelectedItem as RoamingModel).Uri);
            }
        }

        private void ClearFavouritesButtonClick(object sender, RoutedEventArgs e)
        {
            ApplicationData.Current.RoamingSettings.Values.Clear();
            FavoritesListBox.ItemsSource = null;
            favStops = new ObservableCollection<RoamingModel>();
            ApplicationData.Current.RoamingSettings.Values["favStopsCount"] = 0;
        }

        private void ClearHistoryButtonClick(object sender, RoutedEventArgs e)
        {
            ApplicationData.Current.LocalSettings.Values.Clear();
            LastSearchesListBox.ItemsSource = null;
            lastStops = new ObservableCollection<RoamingModel>();
            ApplicationData.Current.LocalSettings.Values["lastStopsCount"] = 0;
        }
        private void RefreshButtonClick(object sender, RoutedEventArgs e)
        {
            if (lastStop!=null)
            {
                GetStopByUri(lastStop.Uri);
            }
            
        }

        private void MoreInfoButtonClick(object sender, RoutedEventArgs e)
        {
            if (lastStop != null)
            {
                this.Frame.Navigate(typeof(BusSchedule), lastStop.Uri);
            }
        }
    }
}
