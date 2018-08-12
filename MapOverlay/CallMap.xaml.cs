using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MapOverlay
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CallMap : ContentPage
	{
		public CallMap ()
		{
			InitializeComponent ();
			
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			tela();
		}

		private async Task tela()
		{
			await Navigation.PushModalAsync(new MapPage());
		}
	}
}