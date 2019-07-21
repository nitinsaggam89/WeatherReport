using System;
using System.IO;
using System.Net;
using WeatherReportWebJob.Constants;
using WeatherReportWebJob.Interfaces;
using WeatherReportWebJob.Models;

namespace WeatherReportWebJob.Repositories
{
    class WeatherReportRepository : IWeatherReportRepository
    {
        public void callWeatherReportEndpoint(City city)
        {
            HttpWebRequest apiRequest = WebRequest.Create(Configurations.OpenWeatherMapApi.Replace("cityId", city.CityId)) as HttpWebRequest;
            string filePathName = Configurations.CityReportLocation + city.CityName + "-Report-" + DateTime.Now.ToShortDateString() + ".txt";
            try
            {
                File.Create(filePathName).Close();
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    writeWeatherReportToFile(filePathName, response);
                }
            }
            catch (Exception ex)
            {
                File.Delete(filePathName);
                throw ex;
            }
        }
        private void writeWeatherReportToFile(string filePath, HttpWebResponse response)
        {
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var stream = new StreamWriter(filePath);
            stream.WriteLine(reader.ReadToEnd());
            stream.Close();
        }
    }
}
