using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasel.View.RecervePages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wasel.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TravelPage : ContentPage
	{
		public TravelPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReceveTicketPage());
        }
    }
}