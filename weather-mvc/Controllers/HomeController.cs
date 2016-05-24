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
            //WeatherResponse resp = wr.GetWeatherOpenWeatherMap(location, timescale);
            WeatherResponse resp = wr.GetWeatherNWS(location);
          
            ViewBag.responseHTML = resp.getHTML();
            return View();
        }

        
       
    }
}