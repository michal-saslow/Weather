
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Repository
{
    public interface IWeatherRepository
    {
        String GetWeaterByCity(String city);
        Task<double> GetTemp(String city);
        Task<string> GetJsonDataFromUrl(String city);
        Task<String> GetCondition(String city);
    }
}
