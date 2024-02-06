
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Sevice
{
    public interface IWeatherService
    {
        String GetWeaterByCity(String city);
        Task<double> GetTemp(String city);
        Task<string> GetJsonDataFromUrl(String city);
        Task<String> GetCondition(String city);
    }
}
