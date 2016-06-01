using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    class HourlyWeatherResponse : WeatherResponse
    {
        public City city { get; set; }
        public string cod { get; set; }
        public string message { get; set; }
        public int cnt { get; set; }
        public List<HourlyItem> list { get; set; }

        public class City
        {
            public string id { get; set; }
            public string name { get; set; }
            public Coord coord { get; set; }
            public string country { get; set; }
        }
        public class Coord
        {
            public float lat { get; set; }
            public float lon { get; set; }
        }
        public class HourlyItem
        {
            public string dt { get; set; }
            public Main main;
            public List<Weather> weather { get; set; }
            public string dt_txt { get; set; }
        }
        public class Main
        {
            public string temp { get; set; }
            public string temp_min { get; set; }
            public string temp_max { get; set; }
            public string pressure { get; set; }
            public string sea_level { get; set; }
            public string grnd_level { get; set; }
            public string humidity { get; set; }
        }
        public class Weather
        {
            public string id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public override string getHTML()
        {
            if (city == null)
            {
                return "<p>Pick a real city.</p>";
            }
            //Generate a table based on the json response.
            string table = "<b>" + city.name + "</b><br/>";
            table += "<table id=\"weatherTable\">";
            table += "<tr><th>Time</th><th>Weather</th><th>Temperature</th><th>Humidity</th>";
            table += "</tr>";
            foreach (HourlyItem item in list)
            {
                table += "<tr>";
                DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                date = date.AddSeconds((double)(int.Parse(item.dt)));
                table += "<td>" + date.ToString() + "</td>";
                table += "<td>" + "<img class=\"weather_icon\" src=\"http://openweathermap.org/img/w/" + item.weather[0].icon + ".png\" />";
                table += item.weather[0].description + "</td>";
                table += "<td>" + item.main.temp + "</td>";
                table += "<td>" + item.main.humidity + "%</td>";
                table += "</tr>";
            }
            table += "</table>";
            return table;
        }
    }
}
