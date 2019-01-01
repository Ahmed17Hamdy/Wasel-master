using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Wasel.RestClient;
using Xamarin.Forms;

namespace Wasel.ViewModel
{
  public  class RegisterViewModel
    {
        ApiServices _apiServices = new ApiServices();

        public string PhoneNumber { get; set; }
        public string  Email { get; set; }
        public string  PassWord { get; set; }
        public string  Message { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async ()=>
                    {
                     var isSuccess =   await _apiServices.RegisterAsync(PhoneNumber, Email, PassWord);
                        if (isSuccess)
                            Message = "Registered Successfully";
                        else
                            Message = "Retry Later";
                    });

            }
        }
    }
}
