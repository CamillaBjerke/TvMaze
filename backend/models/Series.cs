using System;
using System.Collections.Generic;

namespace backend.models
{
    public partial class TvMazeSeries
    {
        public int? Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public List<string> Genres { get; set; }
        public string Status { get; set; }
        public int? Runtime { get; set; }
        public DateTimeOffset Premiered { get; set; }
        public Uri OfficialSite { get; set; }
        public Schedule Schedule { get; set; }
        public Rating Rating { get; set; }
        public int? Weight { get; set; }
        public Network Network { get; set; }
        public Network WebChannel { get; set; }
        public Externals Externals { get; set; }
        public Image Image { get; set; }
        public string Summary { get; set; }
        public long? Updated { get; set; }
        public Links Links { get; set; }
        public Embedded _Embedded { get; set; }
    }

    public partial class Embedded
    {
        public IReadOnlyList<TvMazeEpisode> Episodes { get; set; }
    }

    public partial class Externals
    {
        public int? Tvrage { get; set; }
        public int? Thetvdb { get; set; }
        public string Imdb { get; set; }
    }

    public partial class Image
    {
        public Uri Medium { get; set; }
        public Uri Original { get; set; }
    }

    public partial class Links
    {
        public Previousepisode Self { get; set; }
        public Previousepisode Previousepisode { get; set; }
    }

    public partial class Previousepisode
    {
        public Uri Href { get; set; }
    }

    public partial class Network
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }

    public partial class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Timezone { get; set; }
    }

    public partial class Rating
    {
        public double? Average { get; set; }
    }

    public partial class Schedule
    {
        public string Time { get; set; }
        public List<string> Days { get; set; }
    }
    
}
