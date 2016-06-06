﻿using System;
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
        private City city;
        private DateTime dateAdded;
        private NWSDailyWeatherResponse response;

        private static Dictionary<City, CachedDailyResponse> cache = new Dictionary<City, CachedDailyResponse>();
        private const int CACHE_LENGTH_MINUTES = 60;

        public CachedDailyResponse(City city, NWSDailyWeatherResponse response)
        {
            this.city = city;
            this.response = response;
            this.dateAdded = DateTime.Now;
        }

        public static NWSDailyWeatherResponse getResponse(City city)
        {
            if (!cache.ContainsKey(city) || cache[city].dateAdded.AddMinutes(CACHE_LENGTH_MINUTES) < DateTime.Now)
            {
                cache[city] = new CachedDailyResponse(city, NWSDailyWeatherResponse.fetchResponse(city));
                return cache[city].response;
            }
            else
            {
                return cache[city].response;
            }
        }
    }
}