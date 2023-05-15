using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics.Code
{
    internal class DownloadingFiles
    {
        public async Task TheCode(string url)
        {
            var httpClient = new HttpClient();

            var folderDestination = @"../../..";

            var stream = await httpClient.GetStreamAsync(url);

            var fileName = Path.GetFileName(url);

            using (var fs = File.Create(Path.Combine(folderDestination, fileName)))
            {
                await stream.CopyToAsync(fs);
            }
        }
    }
}
