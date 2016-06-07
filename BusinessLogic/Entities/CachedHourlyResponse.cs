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
        private LatLong location;
        private DateTime dateAdded;
        private NWSHourlyWeatherResponse response;

        private static Dictionary<LatLong, CachedHourlyResponse> cache = new Dictionary<LatLong, CachedHourlyResponse>();
        private const int CACHE_LENGTH_MINUTES = 60;

        public CachedHourlyResponse(LatLong location, NWSHourlyWeatherResponse response)
        {
            this.location = location;
            this.response = response;
            this.dateAdded = DateTime.Now;
        }

        public static NWSHourlyWeatherResponse getResponse(LatLong location)
        {
            if (!cache.ContainsKey(location) || cache[location].dateAdded.AddMinutes(CACHE_LENGTH_MINUTES) < DateTime.Now)
            {
                Console.WriteLine("City not in cache.  Adding.");
                cache[location] = new CachedHourlyResponse(location, NWSHourlyWeatherResponse.fetchResponse(location));
                return cache[location].response;
            }
            else
            {
                return cache[location].response;
            }
        }
    }
}
