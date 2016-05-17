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
    public class WeatherResponse
    {
        public City city { get; set; }
        public string cod { get; set; }
        public string message { get; set; }
        public int cnt { get; set; }
        public List<Item> list { get; set; }
    } 
    public class City
    {
        public string id{ get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
    }
    public class Coord
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }
    public class Item
    {
        public string dt { get; set; }
        public Temp temp { get; set; }
        public string pressure { get; set; }
        public string humidity { get; set; }
        public List<Weather> weather { get; set; }
        public string speed { get; set; }
        public string deg { get; set; }
        public string clouds { get; set; }
    }
    public class Temp {
        public string day { get; set; }
        public string min { get; set; }
        public string max { get; set; }
        public string night { get; set; }
        public string eve { get; set; }
        public string morn { get; set; }
    }
    public class Weather
    {
        public string id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }


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
                    WeatherResponse obj = JsonConvert.DeserializeObject<WeatherResponse>(s);
                    return obj;
                }
            }

            return null;

        }
    }
}
