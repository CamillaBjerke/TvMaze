using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using backend.models;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Reflection;

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
    }
}
