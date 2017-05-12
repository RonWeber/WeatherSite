using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class CityLogic
    {
        private List<City> list = new List<City>();

        public CityLogic()
        {
            //TODO: Cache this or do it asynchronously.
            list = createCityList(); 
        }

        public City getCityByName(string name)
        {
            foreach (City c in list)
            {
                if (c.name.ToLower() == name.ToLower()) return c;
            }
            return null;
        }

        private List<City> createCityList()
        {
            weather.gov.ndfdXML w = new weather.gov.ndfdXML();
            string s = w.LatLonListCityNames("1234");
            XDocument xDoc = XDocument.Parse(s);
            XElement mainElement = xDoc.Element("dwml");

            string latLongList = (string)mainElement.Element("latLonList");
            string cityNameList = (string)mainElement.Element("cityNameList");
            string[] latLongs = latLongList.Split(' ');
            string[] cityNames = cityNameList.Split('|');

            List<City> list = new List<City>();
            for (int i = 0; i < latLongs.Length; i++)
            {
                string latitude = latLongs[i].Split(',')[0];
                string longitude = latLongs[i].Split(',')[1];
                string cityNoState = cityNames[i].Split(',')[0];
                string state = cityNames[i].Split(',')[1];
                list.Add(new City(cityNoState, state, Convert.ToDecimal(latitude), Convert.ToDecimal(longitude)));
            }
            return list;
        }
    }
}
