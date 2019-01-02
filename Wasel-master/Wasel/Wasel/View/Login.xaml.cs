using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wasel.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await Task.Delay(20);
        //    await Task.WhenAll(SplashGrid.FadeTo(0, 2000), SplashImg.ScaleTo(10, 2000));
            
        //}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new Regester();
        }
    }
}