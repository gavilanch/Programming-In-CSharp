using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Code
{
    internal class SendingValuesThroughTheHeader
    {
        public async Task TheCode(string url)
        {
            var httpClient = new HttpClient();

            // Example 1: A request without sending a value through the header
            Console.WriteLine("Example 1:");
            Console.WriteLine(await httpClient.GetStringAsync(url));

            // Example 2:  A request sending a value through the header

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, url))
            {
                httpRequest.Headers.Add("customValue", "I am Claudia");
                var response = await httpClient.SendAsync(httpRequest);
                Console.WriteLine("Example 2:");
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }

            Console.WriteLine(await httpClient.GetStringAsync(url));

            // Example 3: Always sending a value through a header

            Console.WriteLine("Example 3");

            httpClient.DefaultRequestHeaders.Add("customValue", "I am Robert");

            Console.WriteLine(await httpClient.GetStringAsync(url));

            Console.WriteLine(await httpClient.GetStringAsync(url));
        }
    }
}
