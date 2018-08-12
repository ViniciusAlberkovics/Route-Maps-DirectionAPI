using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapOverlay.Models
{
   public class ResultRoute
    {
        public string Summary { get; set; }

        [JsonProperty("overview_polyline")]
        public Polyline Polyline { get; set; }
    
        public ResultBounds Bounds { get; set; }
       
        public IEnumerable<ResultLeg> Legs { get; set; }
    }
}
