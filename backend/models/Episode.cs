using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.models
{
    public partial class TvMazeEpisode
    {
        public uint id { get; set; }
        public Uri url { get; set; }
        public string name { get; set; }
        public int season { get; set; }
        public int number { get; set; }
        public DateTime? airdate { get; set; }
        public DateTimeOffset? airstamp { get; set; }
        public int runtime { get; set; }
        public Image image { get; set; }
        public string summary { get; set; }
        public Links _links { get; set; }
        
    }
}
