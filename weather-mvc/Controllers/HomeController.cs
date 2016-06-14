using BusinessLogic;
using BusinessLogic.Entities;
using BusinessLogic.gov.weather.graphical;
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

        public ActionResult WeatherAnswerPartial(String location, String timescale = "daily")
        {
            WeatherResponse resp;
            if (String.IsNullOrEmpty(location))
            {
                resp = new ErrorWeatherResponse("No city name was given.");
            }
            else if (location.Length == 5 && location.All(char.IsDigit))
            {
                WeatherLogic logic = new WeatherLogic();
                resp = logic.GetWeatherNWSByZIP(location, timescale.Equals("daily"));
            }
            else
            {
                WeatherLogic logic = new WeatherLogic();
                resp = logic.GetWeatherNWSbyCity(location, timescale.Equals("daily"));
            }            
            
            ViewBag.responseHTML = resp.getHTML();
            return PartialView();
        }

        public ActionResult WeatherAnswerPartialFromLatLong(String latitude, String longitude, String timescale = "daily")
        {
            WeatherLogic logic = new WeatherLogic();
            WeatherResponse resp = logic.GetWeatherNWSByLatLong(Decimal.Parse(latitude), Decimal.Parse(longitude), timescale.Equals("daily"));

            ViewBag.responseHTML = resp.getHTML();
            return PartialView("WeatherAnswerPartial");
        }
    }
}