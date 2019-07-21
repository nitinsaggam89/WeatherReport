using WeatherReportWebJob.Models;

namespace WeatherReportWebJob.Interfaces
{
    interface IWeatherReportRepository
    {
        void callWeatherReportEndpoint(City city);
    }
}
