using System.Collections.Generic;
using System.IO;
using System.Linq;
using WeatherReportWebJob.Constants;
using WeatherReportWebJob.Models;

namespace WeatherReportWebJob.Repositories
{
    class CsvExtractor
    {
        public List<City> CsvObject() {
            return File.ReadAllLines(Configurations.FilePath).Skip(1).Select(v => FromCsv(v)).ToList();
        }

        private City FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            return new City { CityId = values[0], CityName = values[1] };
        }
    }
}
