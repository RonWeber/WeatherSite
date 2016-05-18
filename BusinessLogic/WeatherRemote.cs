using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    

    public class WeatherRemote
    {
        public WeatherRemote()
        {

        }

        public WeatherResponse GetWeather(String location, String timescale = "daily")
        {
            Boolean isDaily = timescale.Equals("daily");
            //Send a request
            String url = "http://api.openweathermap.org/data/2.5/forecast";
            if (isDaily)
            {
                url += "/daily";
            }
            url += "?q=" + location + ",us&units=imperial&APPID=973750fb2a9176013240a683b5f49e59";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //Parse the json using the LINQ API
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string s = reader.ReadToEnd();
                    WeatherResponse obj;
                    if (isDaily)
                        obj = JsonConvert.DeserializeObject<DailyWeatherResponse>(s);
                    else
                        obj = JsonConvert.DeserializeObject<HourlyWeatherResponse>(s);
                    return obj;
                }
            }

            return null;

        }
    }
}
