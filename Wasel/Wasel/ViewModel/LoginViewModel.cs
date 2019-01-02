using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Wasel.RestClient;
using Wasel.Model;
using Xamarin.Forms;

namespace Wasel.ViewModel
{
   public  class LoginViewModel
    {
        private  readonly ApiServices _apiservice = new ApiServices();
        public string Email { get; set; }
        public string  PassWord { get; set; }
        public string FireBase { get; set; }
        public string DeviceId { get; set; }
        public string PhoneNumber { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async ()=>
                {
                  await _apiservice.LoginAsync(PhoneNumber , Email, PassWord ,FireBase, DeviceId );
                } );
            }
        }
    }
}
