using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapOverlay
{
	public class CustomMap : Map
	{
		public static readonly BindableProperty ShapeCoordinatesProperty =
			BindableProperty.Create(nameof(RouteCoordinates),
				typeof(List<Position>),
				typeof(CustomMap),
				new List<Position>(), BindingMode.TwoWay);

		public List<Position> RouteCoordinates
		{
			get { return (List<Position>)GetValue(ShapeCoordinatesProperty); }
			set { SetValue(ShapeCoordinatesProperty, value); }
		}

		public CustomMap ()
		{
			RouteCoordinates = new List<Position> ();
		}
	}
}

