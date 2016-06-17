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
    class NWSDailyWeatherResponse : WeatherResponse
    {
        private NDFDgenByDay.dwml information;

        public static NWSDailyWeatherResponse fetchResponse(LatLong location)
        {
            ndfdXML request = new ndfdXML();
            //string response = request.NDFDgenByDay(location.getLatitude(), location.getLongitude(), DateTime.UtcNow.AddHours(-7), "10", unitType.e, formatType.Item24hourly);
            //What about subtracting 3 extra hours so we get the previous predicition as well?
            string response = request.NDFDgenByDay(location.getLatitude(), location.getLongitude(), DateTime.UtcNow.AddHours(-10), "10", unitType.e, formatType.Item24hourly);

            XmlSerializer serializer = new XmlSerializer(typeof(Entities.NDFDgenByDay.dwml));

            Entities.NDFDgenByDay.dwml weather = (Entities.NDFDgenByDay.dwml)serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(response)));

            return new NWSDailyWeatherResponse(weather);
        }

        public NWSDailyWeatherResponse(NDFDgenByDay.dwml parsedXML)
        {
            information = parsedXML;
        }

        public override string getHTML()
        {
            if (information?.data?.location == null)
            {
                return "<p>Error.</p>";
            }
            string table = "<div class='container'>";
            for (int i = 1; i < information.data.timelayout[0].Items.Length; i += 2)
            {
                table += "<div class='row'>";               
                DateTime dt = (DateTime)information.data.timelayout[0].Items[i];

                //Date
                table += "<div class='col-sm-2'><span class='words_big'>" + dt.DayOfWeek + "</span><br/>" +  dt.ToShortDateString() + "</div>";

                table += "<div class='col-sm-4'>";
                //Image
                if (information?.data?.parameters?.conditionsicon?.iconlink[i / 2] != null)
                    table += "<img class=\"weather_icon\" src=\"" + information.data.parameters.conditionsicon.iconlink[i / 2] + "\" />";
                //Weather
                if (information?.data?.parameters?.weather?.weatherconditions[i / 2]?.weathersummary != null)
                    table += information.data.parameters.weather.weatherconditions[i / 2].weathersummary;
                
                table += "</div>";
                table += "<div class='col-sm-6'>";
                table += "<div class='inline'><span class='words_small'>Low</span><br/><span class='words_med' >" + information.data.parameters.temperature[1].value[i / 2] + "&deg</span></div>";
                table += "<div class='inline'><span class='words_small'>High</span><br/><span class='words_med' >" + information.data.parameters.temperature[0].value[i / 2] + "&deg</span></div>";
                if (!string.IsNullOrEmpty(information.data.parameters.probabilityofprecipitation.value[i]))
                    table += "<div class='inline'><span class='words_small'>Precip</span><br/><span class='words_med' >" + information.data.parameters.probabilityofprecipitation.value[i] + "%</span></div>";

                //End temperature and row.
                table += "</div></div>";
            }

            table += "</div>";
            return table;
        }
    }
}
