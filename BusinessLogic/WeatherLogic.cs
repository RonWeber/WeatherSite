using BusinessLogic.Entities;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class WeatherLogic
    {

        public static CityLogic cityList;

        public WeatherLogic()
        {
            if (cityList == null)
            {
                cityList = new CityLogic();
            }
        }

        public WeatherResponse GetWeatherOpenWeatherMap(string location, string timescale = "daily")
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
                        obj = JsonConvert.DeserializeObject<OWMDailyWeatherResponse>(s);
                    else
                        obj = JsonConvert.DeserializeObject<OWMHourlyWeatherResponse>(s);
                    return obj;
                }
            }
            return null;

        }

        public WeatherResponse GetWeatherNWSbyCity(String cityName, bool isDaily)
        {
            
            City city = cityList.getCityByName(cityName);
            if (city == null) return new ErrorWeatherResponse("No city with this name was found.");
            if (isDaily)
            {
                return CachedDailyResponse.getResponse(city);
            }
            else
            {
                return CachedHourlyResponse.getResponse(city);
            }
        }

        public WeatherResponse GetWeatherNWSByZIP(String zipCode, bool isDaily)
        {
            weather.gov.ndfdXMLPortTypeClient ndfd = new weather.gov.ndfdXMLPortTypeClient();
            string xml = ndfd.LatLonListZipCode(zipCode);
            XDocument xdoc = XDocument.Parse(xml);
            XElement mainElement = xdoc.Element("dwml");
            string latLongList = (string)mainElement.Element("latLonList");
            string[] latAndLong = latLongList.Split(','); //This may fail if we somehow get more than one answer, but since we only asked one question, it shouldn't.

            LatLong location = new LatLong(Decimal.Parse(latAndLong[0]), Decimal.Parse(latAndLong[1]));
            if (isDaily)
            {
                return CachedDailyResponse.getResponse(location);
            }
            else
            {
                return CachedHourlyResponse.getResponse(location);
            }
        }

        public WeatherResponse GetWeatherNWSByLatLong(decimal latitude, decimal longitude, bool isDaily)
        {
            LatLong location = new LatLong(latitude, longitude);
            if (isDaily)
            {
                return CachedDailyResponse.getResponse(location);
            }
            else
            {
                return CachedHourlyResponse.getResponse(location);
            }
        }
    }
}
