using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasel.Model;
using Wasel.Services;
using Wasel.View.HomePage;
using Wasel.View.PopUps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wasel.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Regester : ContentPage
	{
		public Regester ()
		{
			InitializeComponent ();
            
		}
        RegesterService res = new RegesterService();
        private async void Regbtn_Clicked(object sender, EventArgs e)
        {

            bool BoolServ = true;
            if (EntryName.Text == null || EntryEmail.Text == null || EntryPassword.Text == null || EntryPhone.Text == null)
            {
                await DisplayAlert("Incomplete Information", "Please complete the required* fields", "OK");
                BoolServ = false;
                return;

            }
            else if (EntryName.Text.Length < 1 || EntryEmail.Text.Length < 1 || EntryPassword.Text.Length < 1 || EntryPhone.Text.Length < 1)
            {
                await DisplayAlert("Incomplete Information", "Please complete the required* fields", "OK");
                BoolServ = false;
                return;
            }
            else if (EntryPassword.Text != ConfirmPassword.Text)
            {
                await DisplayAlert("Incomplete Information", "Bassword Not Matching !!", "OK");
                return;
            }
            else
            {
                User _user = new User
                {
                    name = EntryName.Text,
                    email = EntryEmail.Text,
                    password = EntryPassword.Text,
                    phone = EntryPhone.Text,
                    country = 1,
                    device_id = "192.168.1.20",
                    firebase_token = "jncksnhkjvhshuvhushuvhiulsvhlsivivsvh",
                };
                //List<User> _users = await res.GetAsync();
                //if (_users.Where(s => s.Email == _user.Email).Count() > 0)
                //{   // User exists
                //    await DisplayAlert("User exists", "User with specified email exists", "OK");
                //    return;
                //}

                if (BoolServ)
                {
                    var Param = await res.PostAsync(_user);
                    await PopupNavigation.Instance.PushAsync(new RequestPopUp(Param));
                    App.Current.MainPage = new MenuPage();
                }

            }


        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new Login();
        }
    }
}