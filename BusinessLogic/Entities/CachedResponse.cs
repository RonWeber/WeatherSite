using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    class CachedResponse
    {
        private City city;
        private DateTime dateAdded;
        private NWSWeatherResponse response;

        private static Dictionary<City, CachedResponse> cache = new Dictionary<City, CachedResponse>();
        private const int CACHE_LENGTH_MINUTES = 60;

        public CachedResponse(City city, NWSWeatherResponse response)
        {
            this.city = city;
            this.response = response;
            this.dateAdded = DateTime.Now;
        }

        public static NWSWeatherResponse getResponse(City city)
        {
            if (!cache.ContainsKey(city) || cache[city].dateAdded.AddMinutes(CACHE_LENGTH_MINUTES) < DateTime.Now)
            {
                cache[city] = new CachedResponse(city, NWSWeatherResponse.fetchResponse(city));
                return cache[city].response;
            }
            else
            {
                return cache[city].response;
            }
        }
    }
}
