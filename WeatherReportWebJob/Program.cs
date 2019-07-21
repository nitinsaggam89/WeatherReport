using System;
using System.Collections.Generic;
using WeatherReportWebJob.Models;
using WeatherReportWebJob.Repositories;

namespace WeatherReportWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Weather reports creation started..");
                List<City> values = new CsvExtractor().CsvObject();
                storeCityWeatherReportInDirectory(values);
                Console.WriteLine("Weather reports created successfully!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Weather report failed: " + ex.Message);
            }
        }
        public static void storeCityWeatherReportInDirectory(List<City> cities)
        {
            cities.ForEach(c =>
            {
                new WeatherReportRepository().callWeatherReportEndpoint(c);
            });
        }
    }
}
