using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherReportWebJob.Constants
{
    public static class Configurations
    {
        public const string ApiKey = "aa69195559bd4f88d79f9aadeb77a8f6";
        public const string FilePath = @"C:\Users\Lenovo pc\Documents\CityDetailsSheet.csv";
        public const string OpenWeatherMapApi = "http://api.openweathermap.org/data/2.5/weather?id=cityId&appid=" + ApiKey + "&units=metric";
        public const string CityReportLocation = @"D:\Nitin\f-drive data\Nitin\CityWeatherReport\";
    }
}
