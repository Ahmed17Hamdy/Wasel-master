using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Wasel.RestClient
{
    public class RestClient<T>
    {
        private const string WebServiceUrl = "";
        public async Task<List<T>> GetAsync()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(WebServiceUrl);
            var taskModels = JsonConvert.DeserializeObject<List<T>>(json);
            return taskModels;
        }
        public async Task<bool> PostAsync(T t)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpcontent = new StringContent(json);
            httpcontent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(WebServiceUrl, httpcontent);
            return result.IsSuccessStatusCode;
        }
        public async Task<bool> PutAsync(int id, T t)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpcontent = new StringContent(json);
            httpcontent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(WebServiceUrl + id, httpcontent);
            return result.IsSuccessStatusCode;
        }
        public async Task<bool> DeletAsync(int id, T t)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpcontent = new StringContent(json);
            httpcontent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.DeleteAsync(WebServiceUrl + id);
            return result.IsSuccessStatusCode;
        }


    }
}
