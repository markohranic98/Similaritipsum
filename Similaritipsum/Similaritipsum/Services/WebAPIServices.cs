using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Similaritipsum.Services
{
    internal class WebAPIServices
    {
        private static readonly TextServices _textServices = new TextServices();
        private static readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Method that fetches generated lorem ipsum text
        /// </summary>
        /// <param name="length"></param>
        /// <param name="numberOfParagraphs"></param>
        /// <returns></returns>
        public static string GetLoremIpsum(string length, string numberOfParagraphs)
        {
            string result;
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("https://loripsum.net/");
                HttpResponseMessage response = client.GetAsync("api/1/short").Result;
                response.EnsureSuccessStatusCode();
                result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Result: " + result);
            }
            
            return _textServices.RemoveSpecialCharacters(Regex.Replace(result, "<.*?>", String.Empty)).ToLower();
        }
    }
}
