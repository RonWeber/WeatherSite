using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    class CachedResponse
    {
        private string cityName;
        private DateTime dateAdded;
        private NWSWeatherResponse response;

        private static Dictionary<String, CachedResponse> cache = new Dictionary<string, CachedResponse>();
        private const int CACHE_LENGTH_MINUTES = 60;

        public CachedResponse(String cityName, NWSWeatherResponse response)
        {
            this.cityName = cityName;
            this.response = response;
            this.dateAdded = DateTime.Now;
        }

        public static NWSWeatherResponse getResponse(String cityName)
        {
            if (!cache.ContainsKey(cityName) || cache[cityName].dateAdded.AddMinutes(CACHE_LENGTH_MINUTES) < DateTime.Now)
            {
                cache[cityName] = new CachedResponse(cityName, NWSWeatherResponse.fetchResponse(cityName));
                return cache[cityName].response;
            }
            else
            {
                return cache[cityName].response;
            }
        }
    }
}
