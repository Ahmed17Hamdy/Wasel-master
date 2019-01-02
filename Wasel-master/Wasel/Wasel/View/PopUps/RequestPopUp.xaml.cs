using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasel.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wasel.View.PopUps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RequestPopUp : PopupPage
	{
		public RequestPopUp (Request rq)
		{
			InitializeComponent ();
            rq.data = LblData.Text;
            rq.message = LblMessage.Text;
            rq.success = LblSuc.Text;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}