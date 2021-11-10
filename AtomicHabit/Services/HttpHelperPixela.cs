using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AtomicHabit.Services
{
    public class HttpHelperPixela
    {
        // In my case this is https://localhost:44366/
        private const string apiBasicUri = "https://pixe.la/v1/users";
        private const string DATA = @"{
            ""Token""Component 2"",
            ""usernamehis is a JIRA component"",
            ""agreeTermsOfService"": ""yes,
            ""notMinor"": ""yes}";


        public static async Task Post<T>(string url, T contentValue)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                //var content = new StringContent(JsonConvert.SerializeObject(contentValue), "application/json");
                HttpRequestMessage result = client.PostAsync( content).Result;
                if (result.IsSuccessStatusCode)
                {
                    string msg = result.Content.ReadAsStringAsync().Result;
                }
                else
                {

                }
                
            }
        }

        public static async Task Put<T>(string url, T stringValue)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var content = new StringContent(JsonConvert.SerializeObject(stringValue), Encoding.UTF8, "application/json");
                var result = await client.PutAsync(url, content);
                result.EnsureSuccessStatusCode();
            }
        }

        public static async Task<T> Get<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }

        public static async Task Delete(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var result = await client.DeleteAsync(url);
                result.EnsureSuccessStatusCode();
            }
        }
    }
}
