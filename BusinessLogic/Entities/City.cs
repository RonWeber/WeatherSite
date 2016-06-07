using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BusinessLogic.Entities
{
    public class City : LatLong
    {
        public String name;
        public String state;

        public City(String name, String state, decimal latitude, decimal longitude) 
            : base(latitude, longitude)
        {
            this.name = name;
            this.state = state;
        }
    }






}
