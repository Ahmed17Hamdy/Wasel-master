using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Wasel.Model;

namespace Wasel.Services
{
    public class RegisterService
    {
        private const string WebServiceUrl = "http://wassel.alsalil.net/api/register";

        public async Task<List<User>> GetAsync()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(WebServiceUrl);
            var taskModels = JsonConvert.DeserializeObject<List<User>>(json);
            return taskModels;
        }

       

        public async Task<Request> PostAsync(User t)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpcontent = new StringContent(json);
            httpcontent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(WebServiceUrl, httpcontent);
            var ResBack = result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return await Task.Run(()=> JsonConvert.DeserializeObject<Request>(ResBack.ToString()));
        }
    }
}
