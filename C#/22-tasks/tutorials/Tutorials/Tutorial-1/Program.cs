using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tutorial_1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            Task<HttpStatusCode> download1 = ProcessApiAsync("http://get-simple.info/api/start/", client);
            Task<HttpStatusCode> download2 = ProcessApiAsync("http://get-simple.info/api/extend/?id=1", client);

            HttpStatusCode code1 = await download1;
            HttpStatusCode code2 = await download2;

            Console.WriteLine($"Statuses: {0} | {1}", code1, code2);
        }


        static async Task<HttpStatusCode> ProcessApiAsync(string url, HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"{ url,-45} {responseBody,9}");

            return response.StatusCode;
        }
    }
}
