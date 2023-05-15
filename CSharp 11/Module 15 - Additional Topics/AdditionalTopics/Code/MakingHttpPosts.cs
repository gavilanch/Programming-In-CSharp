using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Code
{
    internal class MakingHttpPosts
    {
        public async Task TheCode(string url)
        {
            var httpClient = new HttpClient();

            // Example 1: Simple Post using PostAsJsonAsync

            var wf = new WeatherForecast()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Summary = "It is hot!!!",
                TemperatureC = 30
            };

            var response = await httpClient.PostAsJsonAsync(url, wf);

            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine("The body of the response is " + body);
            }

            // Example 2: using PostAsync

            var wfSerialized = JsonConvert.SerializeObject(wf);
            var stringContent = new StringContent(wfSerialized, Encoding.UTF8, "application/json");
            var response2 = await httpClient.PostAsync(url, stringContent);

            if (response2.IsSuccessStatusCode)
            {
                var body = await response2.Content.ReadAsStringAsync();
                Console.WriteLine("The body of the response is " + body);
            }



        }
    }
}
