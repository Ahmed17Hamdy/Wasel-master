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
       private  readonly ApiServices  _apiservices = new ApiServices();

        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpass { get; set; }
        public string firebase_token { get; set; }
        public string device_id { get; set; }
        public string country { get; set; }
        public string phone { get; set; }


        public string  Message { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async ()=>
                    {
                     var isSuccess =   await _apiservices.RegisterAsync(
                         name, 
                         email , password , confirmpass ,
                         firebase_token ,device_id , country ,phone );
                       
                    });

            }
        }
    }
}
