using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core.Repository;
using Weather.Core.Sevice;

namespace Weather.Service
{
    public class WeatherService: IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;
        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public string GetWeaterByCity(string city)
        {
            return _weatherRepository.GetWeaterByCity(city);
        }
        public  async Task<double> GetTemp(string city)
        {
            return await _weatherRepository.GetTemp(city);
        }
        public async Task<String> GetCondition(string city)
        {
            return await _weatherRepository.GetCondition(city);
        }
        public Task<string> GetJsonDataFromUrl(string city)
        {
            return _weatherRepository.GetJsonDataFromUrl(city);
        }
    }
}
