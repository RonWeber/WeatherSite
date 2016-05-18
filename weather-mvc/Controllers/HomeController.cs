using BusinessLogic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace weather_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Weather()
        {
            return View();
        }

        public ActionResult WeatherAnswer(String location, String timescale = "daily")
        {
            WeatherRemote wr = new WeatherRemote();
            WeatherResponse resp = wr.GetWeather(location, timescale);

            ViewBag.responseHTML = resp.getHTML();
            return View();
        }

        
        /*private String buildResponseTable(WeatherResponse res, Boolean isDaily)
        {
            if (res == null || res.city == null)
            {
                return "<p>Pick a real city.</p>";
            }
            //Generate a table based on the json response.
            string table = "<b>" + res.city.name + "</b><br/>";
            table += "<table id=\"weatherTable\">";
            table += "";
            if (isDaily)
            {
                table += "<tr><th>Day</th><th>Weather</th><th>Temperature Low</th><th>Temperature High</th><th>Humidity</th>";
            }
            else {
                table += "<tr><th>Time</th><th>Weather</th><th>Temperature</th><th>Humidity</th>";
            }
            table += "</tr>";
            foreach (Item item in res.list)
            {
                table += "<tr>";
                DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                date = date.AddSeconds((double)(int.Parse(item.dt)));
                if (isDaily)
                {
                    table += "<td>" + date.ToShortDateString() + "</td>";
                }
                else
                {
                    table += "<td>" + date.ToString() + "</td>";
                }
                table += "<td>" + "<img class=\"weather_icon\" src=\"http://openweathermap.org/img/w/" + item.weather[0].icon + ".png\" />";
                table += item.weather[0].description + "</td>";
                if (isDaily)
                {
                    table += "<td>" + item.temp.min + "</td>";
                    table += "<td>" + item.temp.max + "</td>";
                    if (item.humidity != null)
                        table += "<td>" + item.humidity + "%</td>";
                }
                else
                {
                    table += "<td>" + item.temp + "</td>";
                    table += "<td>" + item.humidity + "%</td>";
                }
                table += "</tr>";
            }
            table += "</table>";
            return table;
        }*/
    }
}