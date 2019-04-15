using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KlicWebAPIja
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.ReadLine();
        }

        private static async Task RunAsync()
        {
            using (var klient = new HttpClient())
            {
                klient.BaseAddress = new Uri("http://localhost:24053/");
                klient.DefaultRequestHeaders.Accept.Clear();
                klient.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                    ("application/json"));
               HttpResponseMessage odg= await klient.GetAsync("api/Products/1");
                if (odg.IsSuccessStatusCode)
                {
                    Product p = await odg.Content.ReadAsAsync<Product>();
                    Console.WriteLine(p.Ime+" "+p.Cena);
                }
            }
        }
    }
}
