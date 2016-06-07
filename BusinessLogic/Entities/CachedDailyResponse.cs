using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    //CachedDailyResponse and CachedHourlyResponse are two different classes, as opposed to a generic type
    //because responses are created with a static method (because of serialization), and generic types
    //can't call static methods.
    class CachedDailyResponse
    {
        private LatLong location;
        private DateTime dateAdded;
        private NWSDailyWeatherResponse response;

        private static Dictionary<LatLong, CachedDailyResponse> cache = new Dictionary<LatLong, CachedDailyResponse>();
        private const int CACHE_LENGTH_MINUTES = 60;

        public CachedDailyResponse(LatLong location, NWSDailyWeatherResponse response)
        {
            this.location = location;
            this.response = response;
            this.dateAdded = DateTime.Now;
        }

        public static NWSDailyWeatherResponse getResponse(LatLong location)
        {
            if (!cache.ContainsKey(location) || cache[location].dateAdded.AddMinutes(CACHE_LENGTH_MINUTES) < DateTime.Now)
            {
                cache[location] = new CachedDailyResponse(location, NWSDailyWeatherResponse.fetchResponse(location));
                return cache[location].response;
            }
            else
            {
                return cache[location].response;
            }
        }
    }
}
