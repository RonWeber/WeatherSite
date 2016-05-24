using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Entities;

namespace BusinessLogic
{
    class NWSWeatherResponse : WeatherResponse
    {
        private NDFDgenByDay.dwml information;

        public NWSWeatherResponse(NDFDgenByDay.dwml parsedXML)
        {
            information = parsedXML;
        }

        public override string getHTML()
        {
            if (information?.data?.location == null)
            {
                return "<p>Error.</p>";
            }
            string table = "<table id=\"weatherTable\">";
            table += "<tr><th>Time</th><th>Weather Type</th><th>" + information.data.parameters.temperature[1].name + "</th><th>" + information.data.parameters.temperature[0].name + "</th>";
            table += "</tr>";
            for (int i = 1; i < information.data.timelayout[0].Items.Length; i += 2)
            {
                table += "<tr>";
                table += "<td>" + information.data.timelayout[0].Items[i] + "</td>";
                table += "<td>" + "<img class=\"weather_icon\" src=\"" + information.data.parameters.conditionsicon.iconlink[i / 2] + "\" />";
                table += information.data.parameters.weather.weatherconditions[i / 2].weathersummary + "</td>";
                table += "<td>" + information.data.parameters.temperature[1].value[i / 2] + "</td>";
                table += "<td>" + information.data.parameters.temperature[0].value[i / 2] + "</td>";
                table += "</tr>";
            }

            table += "</table>";
            return table;
        }
    }
}
