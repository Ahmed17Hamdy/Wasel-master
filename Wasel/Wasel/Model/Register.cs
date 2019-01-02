using System;
using System.Collections.Generic;
using System.Text;

namespace Wasel.Model
{
    public  class Register
    {
        public string  name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpass { get; set; }
        public string firebase_token { get; set; }
        public string device_id { get; set; }
        public string country { get; set; }
        public string phone { get; set; }

    }
}
