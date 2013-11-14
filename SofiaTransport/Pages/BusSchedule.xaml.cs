using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Collections.ObjectModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.ApplicationModel.DataTransfer;
using Windows.Graphics.Printing;
using Windows.UI.Xaml.Printing;
using SofiaTransport.Models;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace SofiaTransport
{

    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class BusSchedule : SofiaTransport.Common.LayoutAwarePage
    {
        ObservableCollection<string>[] schedule = new ObservableCollection<string>[24];
        ObservableCollection<ScheduleModel> bindingSchedule = new ObservableCollection<ScheduleModel>();
        string saveUri;

        public BusSchedule()
        {
            this.InitializeComponent();
            RegisterForShare();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string Uri = e.Parameter as string;

            if (!string.IsNullOrWhiteSpace(Uri))
            {
                GetScheduleByUri(FixUri(Uri));
            }
            else
            {
                //TODO no info
            }
        }

        async void GetScheduleByUri(string Uri)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://m.sofiatraffic.bg/schedules/");

            string newUri = Uri + "&h=";
            for (int i = 4; i <= 23; i++)
            {
                newUri = newUri + i.ToString();
                var response = await client.GetAsync(newUri);
                var responseText = await response.Content.ReadAsStringAsync();
                //string firstBusNumber = responseText.Substring(responseText.IndexOf("error") + 52, 12);
                //while (true)
                //{
                //    if (firstBusNumber[firstBusNumber.Length - 1] == '<' || firstBusNumber[firstBusNumber.Length - 1] == '/' || firstBusNumber[firstBusNumber.Length - 1] == 'b')
                //    {
                //        firstBusNumber = firstBusNumber.Remove(firstBusNumber.Length - 1, 1);
                //    }
                //    else break;
                //}
                //string direction = responseText.Substring(responseText.IndexOf("Направлениe:") + 38, responseText.IndexOf("Точно време") - responseText.IndexOf("Направлениe:") - 146);
                //string stop = responseText.Substring(responseText.IndexOf("Спирка (код):") + 21, responseText.IndexOf("Направлениe:") - responseText.IndexOf("Спирка (код):") - 53);
                if (schedule[i] == null)
                {
                    schedule[i] = new ObservableCollection<string>();
                }
                schedule[i].Add(i.ToString() + ":11");
                schedule[i].Add(", ");
                schedule[i].Add(i.ToString() + ":34");
            }
            // StorageFolder storageFolder = KnownFolders.DocumentsLibrary;
            // StorageFile sampleFile = await storageFolder.CreateFileAsync("trams.txt");
            // await Windows.Storage.FileIO.WriteTextAsync(sampleFile, result.ToString());

            for (int i = 4; i <= 23; i++)
            {
                ScheduleModel newHour = new ScheduleModel();
                newHour.Hour = i.ToString();
                newHour.Minutes = "";
                foreach (var e in schedule[i])
                {
                    newHour.Minutes = newHour.Minutes + e;
                }
                bindingSchedule.Add(newHour);
            }
            // ScheduleGrid.ItemsSource = bindingSchedule;
            //cvsSchedule.Source = bindingSchedule;
            ScheduleGrid.ItemsSource = bindingSchedule;
        }

        string FixUri(string oldUri)
        {
            string fixedUri;

            oldUri = oldUri.Substring(oldUri.IndexOf("?") + 3);
            fixedUri = "vehicle?stop=" + oldUri;
            saveUri = fixedUri;
            return fixedUri;
        }
        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void RegisterForShare()
        {
                DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();
                dataTransferManager.DataRequested += new TypedEventHandler<DataTransferManager,
                    DataRequestedEventArgs>(this.ShareTextHandler);
        }

        public void ShareTextHandler(DataTransferManager sender, DataRequestedEventArgs e)
        {
            DataRequest request = e.Request;
            request.Data.Properties.Title = "Сподели разписание";
            request.Data.Properties.Description = "Разписание на транспорт";
            string setText = "";
            foreach (var item in bindingSchedule)
            {
                setText = setText + " " + item.Hour + " " + item.Minutes + "\n";
            }
            request.Data.SetText(setText);
        }

        private void backButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void ListFile(StorageFile file)
        {
            string text = await Windows.Storage.FileIO.ReadTextAsync(file);
            string[] grid=text.Split('|');

            bindingSchedule = new ObservableCollection<ScheduleModel>();
            for (int i = 4; i <= 23; i++)
            {
                ScheduleModel newHour = new ScheduleModel();
                newHour.Hour = i.ToString();
                newHour.Minutes = grid[i-4];
                bindingSchedule.Add(newHour);
            }
            // ScheduleGrid.ItemsSource = bindingSchedule;
            //cvsSchedule.Source = bindingSchedule;
            ScheduleGrid.ItemsSource = bindingSchedule;
        }

        private async void OpenFileButtonClick(object sender, RoutedEventArgs e)
        {
            var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

            openPicker.FileTypeFilter.Add("*");

            var file = await openPicker.PickSingleFileAsync();

            ListFile(file);

        }

        private async void SaveFileButtonClick(object sender, RoutedEventArgs e)
        {
            var text = "";

            foreach (var item in bindingSchedule)
            {
                text = text + item.Minutes + " | ";
            }
            var savePicker = new Windows.Storage.Pickers.FileSavePicker();

            var plainTextFileTypes = new List<string>(new string[] { ".txt" });

            savePicker.FileTypeChoices.Add(
                new KeyValuePair<string, IList<string>>("Plain Text", plainTextFileTypes)
                );

            var saveFile = await savePicker.PickSaveFileAsync();

            if (saveFile != null)
            {
                await Windows.Storage.FileIO.WriteTextAsync(saveFile, text);
                await new Windows.UI.Popups.MessageDialog("File Saved!").ShowAsync();
            }
        }

        private void PinAppButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void PrintButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
