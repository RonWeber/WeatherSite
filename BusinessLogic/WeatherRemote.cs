using BusinessLogic.gov.weather.graphical;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BusinessLogic
{
    

    public class WeatherRemote
    {
        public NWSCityList cityList = new NWSCityList();

        public WeatherRemote()
        {
     
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
                        obj = JsonConvert.DeserializeObject<DailyWeatherResponse>(s);
                    else
                        obj = JsonConvert.DeserializeObject<HourlyWeatherResponse>(s);
                    return obj;
                }
            }
            return null;

        }

        public WeatherResponse GetWeatherNWS(String cityName)
        {
            City city = cityList.getCityByName(cityName);
            ndfdXML request = new ndfdXML();
            string response = request.NDFDgenByDay(city.latitude, city.longitude, DateTime.Now, "10", unitType.e, formatType.Item24hourly);

            XmlSerializer serializer = new XmlSerializer(typeof(Entities.NDFDgenByDay.dwml));

            Entities.NDFDgenByDay.dwml weather = (Entities.NDFDgenByDay.dwml)serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(response)));






            XmlRootAttribute root = new XmlRootAttribute("dwml");
            root.IsNullable = true;
            //XmlSerializer serializer = new XmlSerializer(typeof(NWSResponse));
            //WeatherResponse result = (NWSResponse)serializer.Deserialize(new StringReader(response));
            //return result;
            return null;
        }
    }
}
