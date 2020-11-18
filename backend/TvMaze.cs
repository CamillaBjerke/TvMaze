using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace backend
{
    public class TvMAze
    {
        const string SINGLESSEARCH_PATH = "singlesearch/shows?q=";
        const string URI = "http://api.tvmaze.com/";

        //private static HttpClient client = new HttpClient();
        private static readonly HttpClient _client = new HttpClient()
        {
            BaseAddress = new Uri(URI)
        };


        public static async Task<List<Show>> GetAllShowsInFile()
        {
            List<string> lstShowNamesFromFile = new List<string>();

            //client.BaseAddress = new Uri(URI);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            List<Show> lstAllShowes = new List<Show>();
            string line;  
            
            System.IO.StreamReader file = new System.IO.StreamReader("Shows.txt");  
            while((line = file.ReadLine()) != null)  
            {
                lstShowNamesFromFile.Add(line);
            }
            file.Close();

            foreach(string show in lstShowNamesFromFile)
            {
                Show showByName = await GetShowAsync(SINGLESSEARCH_PATH, show);
                lstAllShowes.Add(showByName);
            }
            return lstAllShowes;
        }

        static async Task<Show> GetShowAsync(string path, string showeName)
        {
            string responseAsString;
            Show show = null;

            HttpResponseMessage response = await _client.GetAsync(path + showeName);
            if (response.IsSuccessStatusCode)
            {
                responseAsString = await response.Content.ReadAsStringAsync();
                show = JsonConvert.DeserializeObject<Show>(responseAsString);
            }
            return show;
        }


        /*public async Task<Show> GetShow(string showName) {
            string responseAsString =  "";

            using (var client = new HttpClient())  
            { 

                HttpResponseMessage response = await client.GetAsync("singlesearch/shows?q=" + showName);  
                if (response.IsSuccessStatusCode)  
                {
                    responseAsString = await response.Content.ReadAsStringAsync();
                    var myDeserializedClass = JsonConvert.DeserializeObject<Show>(responseAsString); 
                    return myDeserializedClass;
                }  
                else  
                {  
                    return null;
                } 
            }  
        }*/

    }
}