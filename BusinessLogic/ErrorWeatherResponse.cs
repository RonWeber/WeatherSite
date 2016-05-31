﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ErrorWeatherResponse : WeatherResponse
    {
        private String errorMessage;

        public ErrorWeatherResponse(String message)
        {
            errorMessage = message;
        }

        public override string getHTML()
        {
            return "<p>Error: " + errorMessage + "</p>";
        }
    }
}
