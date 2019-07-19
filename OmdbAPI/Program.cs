using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OmdbAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi filmas nosaukumu: ");
            string nosaukums = Console.ReadLine();
            //http://www.omdbapi.com/?apikey=7515b556&s=batman

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com");

                var response = client.GetAsync("?apikey=7515b556&s=" + nosaukums).Result;

                if (response.IsSuccessStatusCode)
                {
                    SearchResultData result = response.Content.ReadAsAsync<SearchResultData>().Result;
                    if(result.Response == "True")
                    {
                        Console.WriteLine("Atrastās filmas: ");
                        foreach(var movie in result.Search)
                        {
                            Console.WriteLine("{0} {1}. gads", movie.Title, movie.Year);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Neizdevās izsaukt API");
                    }
                }
                else
                {
                    Console.WriteLine("API nav pieejams");
                }
            }

                Console.Read();
        }
    }
}
