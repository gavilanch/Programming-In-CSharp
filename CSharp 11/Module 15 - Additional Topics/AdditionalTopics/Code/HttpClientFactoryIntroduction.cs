using AdditionalTopics.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Code
{
    internal class HttpClientFactoryIntroduction
    {
        public async Task TheCode(string url)
        {
            // This is bad practice
            //using (var httpClient = new HttpClient())
            //{

            //}

            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);
            var services = serviceCollection.BuildServiceProvider();
            var httpClientFactory = services.GetRequiredService<IHttpClientFactory>();

            // Example 1: Simple usage

            var httpClient = httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync(url);
            Console.WriteLine(await response.Content.ReadAsStringAsync());

            // Example 2: Named clients
            var weatherForecastClient = httpClientFactory.CreateClient("weatherForecast");
            Console.WriteLine("Example 2 WF: " + await weatherForecastClient.GetStringAsync("uppercase"));

            var tasksClient = httpClientFactory.CreateClient("tasks");
            Console.WriteLine("Example 2 tasks: " + await tasksClient.GetStringAsync(""));

            // Example 3: Typed Clients
            var wfClient = services.GetRequiredService<IWeatherForecastClient>();
            var wfList = await wfClient.GetAll();
            Console.WriteLine("amount of wf's " + wfList.Count);

            
        }

        static void Configure(ServiceCollection services)
        {
            // Example 1: Simple usage
            //services.AddHttpClient();

            // Example 2: Named clients
            services.AddHttpClient("weatherForecast", options =>
            {
                options.BaseAddress = new Uri("http://localhost:5247/WeatherForecast/");
                options.DefaultRequestHeaders.Add("customValue", "I am a named client");
            });

            services.AddHttpClient("tasks", options =>
            {
                options.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/");
            });

            // Example 3: Typed Clients
            services.AddHttpClient<IWeatherForecastClient, WeatherForecastClient>();

        }
    }
}
