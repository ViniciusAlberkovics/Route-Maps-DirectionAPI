using Newtonsoft.Json;

namespace MapOverlay.Models
{
    public class ResultBounds
    {
        [JsonProperty("northeast")]
        public Location NorthEast { get; set; }
   
        [JsonProperty("southwest")]
        public Location SouthWest { get; set; }
    }
}
