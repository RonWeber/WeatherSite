using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    //CachedDailyResponse and CachedHourlyResponse are two different classes, as opposed to a generic type
    //because responses are created with the static method fetchResponse (because of serialization), and generic types
    //can't call static methods.
    class CachedHourlyResponse
    {
        private City city;
        private DateTime dateAdded;
        private NWSHourlyWeatherResponse response;

        private static Dictionary<City, CachedHourlyResponse> cache = new Dictionary<City, CachedHourlyResponse>();
        private const int CACHE_LENGTH_MINUTES = 60;

        public CachedHourlyResponse(City city, NWSHourlyWeatherResponse response)
        {
            this.city = city;
            this.response = response;
            this.dateAdded = DateTime.Now;
        }

        public static NWSHourlyWeatherResponse getResponse(City city)
        {
            if (!cache.ContainsKey(city) || cache[city].dateAdded.AddMinutes(CACHE_LENGTH_MINUTES) < DateTime.Now)
            {
                Console.WriteLine("City not in cache.  Adding.");
                cache[city] = new CachedHourlyResponse(city, NWSHourlyWeatherResponse.fetchResponse(city));
                return cache[city].response;
            }
            else
            {
                return cache[city].response;
            }
        }
    }
}
