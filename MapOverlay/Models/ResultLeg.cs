using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapOverlay.Models
{
    public class ResultLeg
    {
        [JsonProperty("start_address")]
        public string StartAddress { get; set; }

        [JsonProperty("end_address")]
        public string EndAddress { get; set; }
 
        [JsonProperty("start_location")]
        public Location StartLocation { get; set; }
      

        [JsonProperty("end_location")]
        public Location EndLocation { get; set; }


        public TextValue Distance { get; set; }

        public TextValue Duration { get; set; }

        public IEnumerable<ResultSteps> Steps { get; set; }
    }
}
