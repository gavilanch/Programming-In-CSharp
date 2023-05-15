using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Code
{
    internal class ParsingErrorsFromTheWebAPI
    {
        public async Task TheCode(string url)
        {
            var httpClient = new HttpClient();

            var wf = new WeatherForecast()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TemperatureC = 55,
                Summary = "It's hot"
            };

            var response = await httpClient.PostAsJsonAsync(url, wf);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Everything is correct");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var json = await response.Content.ReadAsStringAsync();
                var fieldsWithErrors = Utilities.ExtractErrorsFromWebAPI(json);

                foreach (var fieldWithErrors in fieldsWithErrors)
                {
                    Console.WriteLine($"- {fieldWithErrors.Key}");
                    foreach (var error in fieldWithErrors.Value)
                    {
                        Console.WriteLine($"    {error}");
                    }
                }
            }


        }
    }
}
