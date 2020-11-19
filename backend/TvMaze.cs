using backend.models;
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

        private static readonly HttpClient _client = new HttpClient()
        {
            BaseAddress = new Uri(URI)
        };


        public static async Task<List<TvMazeSeries>> GetAllShowsInFile()
        {
            List<string> lstShowNamesFromFile = new List<string>();

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            List<TvMazeSeries> lstAllShowes = new List<TvMazeSeries>();
            string line;  
            
            System.IO.StreamReader file = new System.IO.StreamReader(@"assets\Shows.txt");  
            while((line = file.ReadLine()) != null)  
            {
                lstShowNamesFromFile.Add(line);
            }
            file.Close();

            foreach(string show in lstShowNamesFromFile)
            {
                TvMazeSeries showByName = await GetShowAsync(SINGLESSEARCH_PATH, show);
                lstAllShowes.Add(showByName);
            }
            TvMazeReports.createTop10Report(lstAllShowes);
            TvMazeReports.createSummaryReport(lstAllShowes);
            return lstAllShowes;
        }

        static async Task<TvMazeSeries> GetShowAsync(string path, string showeName)
        {
            string responseAsString;
            TvMazeSeries show = null;

            HttpResponseMessage response = await _client.GetAsync(path + showeName + "&embed=episodes");
            if (response.IsSuccessStatusCode)
            {
                responseAsString = await response.Content.ReadAsStringAsync();
                show = JsonConvert.DeserializeObject<TvMazeSeries>(responseAsString);
            }
            return show;
        }
    }
}