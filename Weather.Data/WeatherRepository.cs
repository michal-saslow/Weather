using Fast.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.Core.Repository;

namespace Weather.Data
{
    public class WeatherRepository: IWeatherRepository
    {
        private readonly DataContext _context;
        private readonly HttpClient _httpClient;
        
        public WeatherRepository(DataContext context)
        {
            _context = context;
            _httpClient = new HttpClient();
        }
        public async Task<string> GetJsonDataFromUrl(String city)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_context.GetUrl(city));
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return json;
            }
            else
            {
                throw new Exception("Failed to retrieve data from the URL.");
            }

        }
        public async Task<double> GetTemp(string city)
        {
            var json = await GetJsonDataFromUrl(city);
            var temp = JsonConvert.DeserializeObject<dynamic>(json).current.temp_c;
            return temp;
        }
        public async Task<String> GetCondition(string city)
        {
            var json = await GetJsonDataFromUrl(city);
            var condition = JsonConvert.DeserializeObject<dynamic>(json).current.condition.text;
            return condition;
        }
        public String GetWeaterByCity(String city)
        {
            return _context.GetUrl(city);
        }
    
}
}
