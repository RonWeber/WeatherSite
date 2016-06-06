using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Entities;
using BusinessLogic.gov.weather.graphical;
using System.Xml.Serialization;
using System.IO;

namespace BusinessLogic.Entities
{
    class NWSHourlyWeatherResponse : WeatherResponse
    {
        
        private NDFDgenHourly.dwml information;

        public static NWSHourlyWeatherResponse fetchResponse(City city)
        {
            ndfdXML request = new ndfdXML();
            weatherParametersType parameters = new weatherParametersType();
            parameters.temp = true; parameters.pop12 = true; parameters.wx = true; parameters.icons = true;
            parameters.wwa = true;
            string response = request.NDFDgen(city.latitude, city.longitude, productType.timeseries, DateTime.Now, 
                DateTime.Now.AddDays(8), unitType.e, parameters);

            XmlSerializer serializer = new XmlSerializer(typeof(Entities.NDFDgenHourly.dwml));

            Entities.NDFDgenHourly.dwml weather = (Entities.NDFDgenHourly.dwml)serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(response)));

            return new NWSHourlyWeatherResponse(weather);
        }

        public NWSHourlyWeatherResponse(NDFDgenHourly.dwml parsedXML)
        {
            information = parsedXML;
        }

        public override string getHTML()
        {
            if (information?.data?.location == null)
            {
                return "<p>Error.</p>";
            }
            string table = "<table class=\"table table-striped table-bordered\" id=\"weatherTable\">";
            table += "<tr><th>Time</th><th>Weather Type</th><th>Temperature</th>";
            table += "</tr>";
            for (int i = 1; i < information.data.timelayout[1].Items.Length; i++)
            {
                table += "<tr>";
                table += "<td>" + information.data.timelayout[1].Items[i] + "</td>";
                table += "<td>" + "<img class=\"weather_icon\" src=\"" + information.data.parameters.conditionsicon.iconlink[i - 1] + "\" />";
                if (information.data.parameters.weather.weatherconditions[i - 1].value != null)
                    table += information.data.parameters.weather.weatherconditions[i - 1].value[0].coverage + " " + information.data.parameters.weather.weatherconditions[i - 1].value[0].weathertype;
                else
                    table += "clear";
                table += "</td>";
                table += "<td>" + information.data.parameters.temperature.value[i - 1] + "</td>";
                table += "</tr>";
            }

            table += "</table>";
            return table;
        }
    }
}
