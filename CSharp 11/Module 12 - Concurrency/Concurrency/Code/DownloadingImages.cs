using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Code
{
    internal class DownloadingImages
    {
        HttpClient httpClient = new HttpClient();

        public async Task TheCode(PictureBox loadingGif)
        {
            loadingGif.Visible = true;

            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var destinationSequential = Path.Combine(currentDirectory, @"images\result-sequential");
            var destinationInParallel = Path.Combine(currentDirectory, @"images\result-parallel");

            PrepareExecution(destinationInParallel, destinationSequential);

            Console.WriteLine("Begin");
            var images = GetImages();

            // Sequential
            var sw = new Stopwatch();
            sw.Start();

            foreach (var image in images)
            {
                await ProcessImage(destinationSequential, image);
            }

            Console.WriteLine($"Sequential - took: {sw.ElapsedMilliseconds / 1000.0} seconds");

            sw.Reset();
            sw.Start();

            var tasksEnumerable = images.Select(async image =>
            {
                await ProcessImage(destinationInParallel, image);
            });

            await Task.WhenAll(tasksEnumerable);

            sw.Stop();

            Console.WriteLine($"Parallel - took: {sw.ElapsedMilliseconds / 1000.0} seconds");


            loadingGif.Visible = false;
        }

        private async Task ProcessImage(string directory, CustomImage image)
        {
            var response = await httpClient.GetAsync(image.URL);
            var content = await response.Content.ReadAsByteArrayAsync();

            Bitmap bitmap;
            using (var ms = new MemoryStream(content))
            {
                bitmap = new Bitmap(ms);
            }

            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            var destination = Path.Combine(directory, image.Title);
            bitmap.Save(destination);
        }

        private void DeleteFiles(string directory)
        {
            var files = Directory.EnumerateFiles(directory);
            foreach (var file in files)
            {
                File.Delete(file);
            }
        }

        private void PrepareExecution(string destinationInParallel,
   string destinationInSequence)
        {
            if (!Directory.Exists(destinationInParallel))
            {
                Directory.CreateDirectory(destinationInParallel);
            }

            if (!Directory.Exists(destinationInSequence))
            {
                Directory.CreateDirectory(destinationInSequence);
            }

            DeleteFiles(destinationInSequence);
            DeleteFiles(destinationInParallel);
        }



        private static List<CustomImage> GetImages()
        {
            var images = new List<CustomImage>();

            for (int i = 0; i < 7; i++)
            {
                images.Add(new CustomImage
                {
                    Title = $"Cacicazgos {i}.png",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/Copia_de_Cacicazgos_de_la_Hispaniola.png/800px-Copia_de_Cacicazgos_de_la_Hispaniola.png"
                });

                images.Add(new CustomImage
                {
                    Title = $"Igneri {i}.png",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Pictografia_igneri.jpg/450px-Pictografia_igneri.jpg"
                });

                images.Add(new CustomImage
                {
                    Title = $"Maroons {i}.png",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Maroons_preparing_to_ambush_a_convoy.jpg/800px-Maroons_preparing_to_ambush_a_convoy.jpg"
                });
            }

            return images;
        }
    }
}
