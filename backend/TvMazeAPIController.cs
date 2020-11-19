using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using backend.models;

namespace backend
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvMazeAPIController : ControllerBase
    {
        [HttpGet]
        public async Task<List<TvMazeSeries>> Get() 
        {
            List<TvMazeSeries> lstAllShows = await TvMAze.GetAllShowsInFile();
            return lstAllShows;
        }

        [HttpGet("{id}")]
        public string Get(int Id) {
            return "Denne er parameterstyrt";
                
        }       
    }
}
