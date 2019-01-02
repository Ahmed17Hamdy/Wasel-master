using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Wasel.Model;

namespace Wasel.RestClient
{
  public  class ApiServices
    {
        public async Task LoginAsync ( string phonenumber , string email , string password , string firebase_token , string device_id)
        {
            var KeyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string , string>("phonenumber", phonenumber ),
                new KeyValuePair<string, string>("email", email ),
                new KeyValuePair<string, string>("password", password),

            };
            var request = new HttpRequestMessage(HttpMethod.Post, "http://wassel.alsalil.net/api/login");
            request.Content = new FormUrlEncodedContent(KeyValues);
            var client = new HttpClient();
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(content);


        }

        public async Task <string> RegisterAsync( 
            string name, string email , string password , string confirmpass ,
            string firebase_token , string device_id , string country , string phone )
        {
            var client = new HttpClient();
            var model = new Register
            {
                name  = name  , 
                email = email ,
            password  = password  ,
            confirmpass = confirmpass ,
            firebase_token = firebase_token  ,
            country = country ,
            phone = phone 
            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
       var response =   await   client.PostAsync("http://wassel.alsalil.net/api/register " , content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
