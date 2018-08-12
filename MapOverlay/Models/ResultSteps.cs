using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapOverlay.Models
{
    public class ResultSteps
    {
        [JsonProperty("start_location")]
        public Location StartLocation { get; set; }
        [JsonProperty("end_location")]
        public Location EndLocation { get; set; }
        public TextValue Distance { get; set; }
        public TextValue Duration { get; set; }
        public Polyline Polyline { get; set; }
        [JsonProperty("html_instructions")]
        public string HtmlInstructions { get; set; }
    }
}
