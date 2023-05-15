using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Code
{
    internal class GetFromJsonAsyncIntroduction
    {
        public async Task TheCode(string url)
        {
            var httpClient = new HttpClient();

            // Example 1: Using GetFromJsonAsync

            var deserializedResponse = await httpClient.GetFromJsonAsync<List<WeatherForecast>>(url);

            Console.WriteLine();
        }
    }
}
