using MapOverlay.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace MapOverlay
{
    public class CustomMapViewModel : BaseViewModel
    {
		#region Properties
		private string _origin;

		public string Origin
		{
			get { return _origin; }
			set { _origin = value; OnPropertyChanged(); }
		}

		private string _destiny;

		public string Destiny
		{
			get { return _destiny; }
			set { _destiny = value; OnPropertyChanged(); }
		}
		public static CustomMap myMap;
		private DirectionsAPI service;
		private readonly string key = "Key_Directions_API";
		#endregion

		public CustomMapViewModel()
		{
			Origin = "Rua Dos Ingleses, 600 - São Paulo, SP";
			Destiny = "Rua Augusta, 1508 - São Paulo, SP";

			service = new DirectionsAPI(key);

			try
			{
				new Thread(GenereteRoute(Origin, Destiny).Wait);
				
				myMap = new CustomMap();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private async Task GenereteRoute(string origin, string destiny)
		{
			try
			{
				var result = await service.GetRoute(Origin, Destiny);


				foreach (var route in result.Routes)
				{
					var line = route.Polyline;
					var polilyne = line.Positions.Select(l => new Position(l.Latitude, l.Longitude)).ToList();

					myMap.RouteCoordinates = polilyne;
					myMap.MoveToRegion(MapSpan.FromCenterAndRadius(polilyne.First(), Distance.FromKilometers(2)));
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
