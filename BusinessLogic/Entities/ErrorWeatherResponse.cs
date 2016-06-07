using System;

namespace BusinessLogic.Entities
{
    public class ErrorWeatherResponse : WeatherResponse
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
