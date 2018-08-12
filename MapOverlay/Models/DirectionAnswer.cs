using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapOverlay.Models
{
    public class DirectionAnswer
    {
		[JsonProperty("status")]
		private string StatusText { get; set; }

		[JsonProperty("routes")]
		public IEnumerable<ResultRoute> Routes { get; set; }
	}
}
