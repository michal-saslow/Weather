

namespace Fast.Data
{

        public class DataContext 
    {
        private readonly String Url;
        
        public DataContext() {
            Url = "https://api.weatherapi.com/v1/forecast.json?key=39f8ecaf506c4f76b3f55139222906&q=TextToReplace&days=3&aqi=yes&alerts=yes";
        }
        public string GetUrl(string city){
              
            return Url.Replace("TextToReplace", city);

         }

}
}