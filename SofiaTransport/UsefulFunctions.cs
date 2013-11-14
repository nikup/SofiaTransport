using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;

namespace SofiaTransport
{
    class UsefulFunctions
    {
        async void GetStop(string s, string lid, string vt, string rid)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://m.sofiatraffic.bg/schedules/");
            string requestUri = "vehicle-vt?s=" + s + "&lid=" + lid + "&vt=" + vt + "&rid=" + rid;
            var response = await client.GetAsync(requestUri);
            var responseText = await response.Content.ReadAsStringAsync();
            StringBuilder result = new StringBuilder();
            string stop = responseText.Substring(responseText.IndexOf("Спирка (код):") + 20, responseText.IndexOf("Направлениe:") - responseText.IndexOf("Спирка (код):") - 35);
            result.Append(stop);
            string direction = responseText.Substring(responseText.IndexOf("Направлениe:") + 27, responseText.IndexOf("Информация") - responseText.IndexOf("Направлениe:") - 73);
            result.Append(direction);
            string time = responseText.Substring(responseText.IndexOf("Информация") + 15, 16);
            result.Append(time);
            string firstBus = responseText.Substring(responseText.IndexOf("пристигане") + 24, 17);
            result.Append(firstBus);

            if (responseText.IndexOf("Автобуси") != -1)
            {
                int start = responseText.IndexOf("arr_info_1");
                while (start != -1)
                {
                    string bus = responseText.Substring(start + 90, 3);
                    if (bus[2] == '<') bus = bus.Remove(2, 1);
                    result.Append(bus);
                    string busTime = responseText.Substring(start + 117, 17);
                    result.Append(busTime);
                    start = responseText.IndexOf("arr_info_1", start + 1);
                }
            }

            if (responseText.IndexOf("Тролейбуси") != -1)
            {
                int start = responseText.IndexOf("arr_info_2");
                while (start != -1)
                {
                    string bus = responseText.Substring(start + 90, 3);
                    if (bus[2] == '<') bus = bus.Remove(2, 1);
                    result.Append(bus);
                    string busTime = responseText.Substring(start + 117, 17);
                    result.Append(busTime);
                    start = responseText.IndexOf("arr_info_2", start + 1);
                }
            }

            if (responseText.IndexOf("Трамваи") != -1)
            {
                int start = responseText.IndexOf("arr_info_3");
                while (start != -1)
                {
                    string bus = responseText.Substring(start + 90, 3);
                    if (bus[2] == '<') bus = bus.Remove(2, 1);
                    result.Append(bus);
                    string busTime = responseText.Substring(start + 117, 17);
                    result.Append(busTime);
                    start = responseText.IndexOf("arr_info_3", start + 1);
                }
            }
            result.ToString();
        }
    }
}
