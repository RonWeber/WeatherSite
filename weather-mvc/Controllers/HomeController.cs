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
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    ViewBag.responseHTML = "<p>Error</p>";
                    return View();
                }
                //Parse the json using the LINQ API
                StreamReader reader = new StreamReader(response.GetResponseStream());
                JObject responseData = JObject.Parse(reader.ReadToEnd());
                ViewBag.responseHTML = buildResponseTable(responseData, isDaily);
            }
            return View();
        }

        private String buildResponseTable(JObject data, Boolean isDaily)
        {
            if (data == null || data["city"] == null)
            {
                return "<p>Pick a real city.</p>";
            }
            //Generate a table based on the json response.
            string table = "<b>" + data["city"]["name"] + "</b><br/>";
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
            foreach(JObject item in data["list"])
            {
                table += "<tr>";
                DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                date = date.AddSeconds((double)(int)item["dt"]);
                if (isDaily)
                {
                    table += "<td>" + date.ToShortDateString() + "</td>";
                }
                else
                {
                    table += "<td>" + date.ToString() + "</td>";
                }
                table += "<td>" + "<img class=\"weather_icon\" src=\"http://openweathermap.org/img/w/" + item["weather"][0]["icon"] + ".png\" />";
                table += item["weather"][0]["description"] + "</td>";
                if (isDaily)
                {
                    table += "<td>" +item["temp"]["min"] + "</td>";
                    table += "<td>" + item["temp"]["max"] + "</td>";
                    if (item["humidity"] != null)
                        table += "<td>" + item["humidity"] + "%</td>";
                }
                else
                {
                    table += "<td>" + item["main"]["temp"] + "</td>";
                    table += "<td>" + item["main"]["humidity"] + "%</td>";
                }
                table += "</tr>";
            }
            table += "</table>";
            return table;
        }
    }
}