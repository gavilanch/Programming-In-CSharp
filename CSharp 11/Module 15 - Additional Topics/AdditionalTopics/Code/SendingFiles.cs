using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Code
{
    internal class SendingFiles
    {
        public async Task TheCode(string url)
        {
            var httpClient = new HttpClient();

            var fileRoute = @"..\..\..\Example.txt";
            var fileName = Path.GetFileName(fileRoute);

            using (var content = new MultipartFormDataContent())
            {
                using (var fs = File.OpenRead(fileRoute))
                {
                    content.Add(new StreamContent(fs), "file", fileName);
                    var response = await httpClient.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();
                }
            }
        }
    }
}
