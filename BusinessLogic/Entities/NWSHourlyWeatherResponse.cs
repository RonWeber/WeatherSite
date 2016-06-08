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

        public static NWSHourlyWeatherResponse fetchResponse(LatLong location)
        {
            ndfdXML request = new ndfdXML();
            weatherParametersType parameters = new weatherParametersType();
            parameters.temp = true; parameters.pop12 = true; parameters.wx = true; parameters.icons = true;
            parameters.wwa = true;  parameters.rh = true; parameters.waveh = true;
            string response = request.NDFDgen(location.getLatitude(), location.getLongitude(), productType.timeseries, DateTime.Now, 
                DateTime.Now.AddDays(8), unitType.e, parameters);

            XmlSerializer serializer = new XmlSerializer(typeof(Entities.NDFDgenHourly.dwml));

            NDFDgenHourly.dwml weather = (Entities.NDFDgenHourly.dwml)serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(response)));

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
            table += "<tr><th>Time</th><th>Weather Type</th><th>Temperature</th><th>Relative Humidity</th><th>12h Precipitation Chance</th>";
            if (weHaveWaves(information)) table += "<th>Wave Height</th>";
            table += "</tr>";
            List<DateTime> threeHourInterval = getStartTimes(information.data.timelayout[1]);
            for (int i = 0; i < threeHourInterval.Count; i++)
            {
                int whereWeAreIn12h = getTimeLayoutIndex(threeHourInterval[i], getStartTimes(information.data.timelayout[0]));
                table += "<tr>";
                table += "<td><b>" + threeHourInterval[i].DayOfWeek + "</b>&nbsp" + threeHourInterval[i].ToString() + "</td>";
                table += "<td>" + "<img class=\"weather_icon\" src=\"" + information.data.parameters.conditionsicon.iconlink[i] + "\" />";
                if (information.data.parameters.weather.weatherconditions[i].value != null)
                    table += information.data.parameters.weather.weatherconditions[i].value[0].coverage + " " + information.data.parameters.weather.weatherconditions[i].value[0].weathertype;
                else
                    table += "clear";
                table += "</td>";
                table += "<td>" + information.data.parameters.temperature.value[i] + "</td>";
                table += "<td>" + information.data.parameters.humidity.value[i] + "%</td>";
                table += "<td>" + information.data.parameters.probabilityofprecipitation.value[whereWeAreIn12h] + "%</td>";
                if (weHaveWaves(information))
                {
                    int whereWeAreInWaves = getTimeLayoutIndex(threeHourInterval[i], getStartTimes(information.data.timelayout[2]));
                    table += "<td>" + information.data.parameters.waterstate.waves.value[whereWeAreInWaves] + " Feet</td>";
                }
                table += "</tr>";
            }

            table += "</table>";
            return table;
        }

        private bool weHaveWaves(NDFDgenHourly.dwml information)
        {
            return information.data.parameters.waterstate.waves.value[0] != null;
        }

        //Gets the index of the nearest time >= currentTime in the time layout specified by layout.
        //Assumes time is in chronological order.
        private int getTimeLayoutIndex(DateTime currentTime, List<DateTime> startTimes)
        {
            for (int i = 0; i < startTimes.Count; i++)
            {
                if (currentTime < startTimes[i]) return i - 1;
            }
            return startTimes.Count - 1;
        }

        //Gets only the start times from a timeLayout
        private List<DateTime> getStartTimes(NDFDgenHourly.dwmlDataTimelayout layout)
        {
            List<DateTime> result = new List<DateTime>();
            for (int i = 0; i < layout.Items.Length; i++)
            {
                if (layout.ItemsElementName[i] == NDFDgenHourly.ItemsChoiceType.startvalidtime)
                {
                    result.Add((DateTime)layout.Items[i]);
                }
            }
            return result;
        }
    }

}
