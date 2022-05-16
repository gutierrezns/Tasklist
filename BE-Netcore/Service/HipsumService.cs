using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BE_Netcore.Service
{
    public class HipsumService
    {
        private readonly string HipsumUrl = "http://hipsum.co/api/";
        private readonly string QueryString = "?type=hipster-centric&sentences=3"; //TODO: replace sentences with randomized number
        static HttpClient client = new HttpClient();


        public HipsumService()
        {
        }
        

        public async Task<List<string>> GetTitlesAsync()
        {
            List<string> titles = null;
            HttpResponseMessage response = await client.GetAsync(HipsumUrl + QueryString);

            if (response.IsSuccessStatusCode)
            {
                await response.Content.ReadAsStringAsync();
                var titulos = response.Content.ToString().Split('\u22C5');
                titles = new List<string>(titulos);

            }
            return titles;
        }

    }
}
