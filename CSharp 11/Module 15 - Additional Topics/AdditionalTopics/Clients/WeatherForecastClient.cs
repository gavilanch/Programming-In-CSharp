using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Clients
{
    internal interface IWeatherForecastClient
    {
        Task<List<WeatherForecast>> GetAll();
    }

    internal class WeatherForecastClient: IWeatherForecastClient
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl = "http://localhost:5247/WeatherForecast/";

        public WeatherForecastClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<WeatherForecast>> GetAll()
        {
            var response = await httpClient.GetFromJsonAsync<List<WeatherForecast>>(baseUrl);

            if (response is null)
            {
                return new List<WeatherForecast>();
            }

            return response;
        }
    }
}
