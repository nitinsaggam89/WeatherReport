namespace WeatherReportWebJob.Constants
{
    public static class Configurations
    {
        public const string ApiKey = "aa69195559bd4f88d79f9aadeb77a8f6";

        // cityIds file path location
        public const string FilePath = @"filePath\CityDetailsSheet.csv";
        public const string OpenWeatherMapApi = "http://api.openweathermap.org/data/2.5/weather?id=cityId&appid=" + ApiKey + "&units=metric";

        // weather report storage location of cities
        public const string CityReportLocation = @"storagePath\CityWeatherReport\";
    }
}
