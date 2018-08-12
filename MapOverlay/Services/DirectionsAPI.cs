using MapOverlay.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MapOverlay.Services
{
    public class DirectionsAPI
    {
		#region Properties
		private readonly string baseUrl = "https://maps.googleapis.com/maps/api/directions/json?origin=";

		private HttpClient _httpClient;

		private readonly string _key;
		#endregion

		public DirectionsAPI(string key) => _key = key;

		public async Task<DirectionAnswer> GetRoute(string origin, string destination)
		{
			try
			{
				_httpClient = new HttpClient();

				StringBuilder url = new StringBuilder();
				url.Append(baseUrl + origin + "&destination=" + destination + "&sensor=false&mode=driving");
				//url.Append("&key=" + _key);
				var request = new HttpRequestMessage(HttpMethod.Get, url.ToString());

				var response = await _httpClient.SendAsync(request);
				var json = await response.Content.ReadAsStringAsync();

				if (response != null)
				{
					var result = JsonConvert.DeserializeObject<DirectionAnswer>(json);

					return result;
				}
				else
					return null;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
