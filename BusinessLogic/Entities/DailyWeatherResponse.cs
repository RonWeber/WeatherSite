using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class DailyWeatherResponse : WeatherResponse
    {
        public City city { get; set; }
        public string cod { get; set; }
        public string message { get; set; }
        public int cnt { get; set; }
        public List<DailyItem> list { get; set; }

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
        public class DailyItem
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
        public class Temp
        {
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

        public override string getHTML()
        {
            if (city == null)
            {
                return "<p>Pick a real city.</p>";
            }
            //Generate a table based on the json response.
            string table = "<b>" + city.name + "</b><br/>";
            table += "<table id=\"weatherTable\">";
            table += "";
            table += "<tr><th>Day</th><th>Weather</th><th>Temperature Low</th><th>Temperature High</th><th>Humidity</th>";
            table += "</tr>";
            foreach (DailyItem item in list)
            {
                table += "<tr>";
                DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                date = date.AddSeconds((double)(int.Parse(item.dt)));
                table += "<td>" + date.ToShortDateString() + "</td>";
                table += "<td>" + "<img class=\"weather_icon\" src=\"http://openweathermap.org/img/w/" + item.weather[0].icon + ".png\" />";
                table += item.weather[0].description + "</td>";
                table += "<td>" + item.temp.min + "</td>";
                table += "<td>" + item.temp.max + "</td>";
                if (item.humidity != null)
                    table += "<td>" + item.humidity + "%</td>";
                table += "</tr>";
            }
            table += "</table>";
            return table;
        }

    }
}
