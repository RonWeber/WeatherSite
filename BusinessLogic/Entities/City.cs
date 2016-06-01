using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BusinessLogic.Entities
{
    public class City
    {
        public String name;
        public String state;
        public decimal latitude;
        public decimal longitude;

        public City(String name, String state, decimal latitude, decimal longitude)
        {
            this.name = name;
            this.state = state;
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }






}
