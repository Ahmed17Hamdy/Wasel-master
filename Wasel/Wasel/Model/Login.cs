using System;
using System.Collections.Generic;
using System.Text;

namespace Wasel.Model
{
   public class Login
    {
        public string email { get; set; }
        public string password { get; set; }
        public string firebase_token { get; set; }
        public string device_id { get; set; }

    }
}
