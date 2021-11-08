using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AtomicHabit.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class HabitAPIController : ControllerBase
    {
        private static HttpClient _httpClient;

        public string responseTest { get; set; }
        static HabitAPIController()
        {
            _httpClient = new HttpClient();

        }
        [Inject]
        public IHttpClientFactory HttpClientFactory { get; set; }
        
        [HttpGet]
        public async Task<string> get(string habit)
        {
            //var URL = "";
            //var response = await _httpClient.GetAsync(URL);
            //return await response.Content.ReadAsStringAsync();

            var httpClient = HttpClientFactory.CreateClient(name: "Pixela");
            responseTest = await httpClient.GetStringAsync(requestUri: $"");
            
        }

        // Create User EndPoint
        // Get Graph EndPoint - {pixela_endpoint}/{USERNAME}/graphs
        // Create Graph EndPoint - {pixela_endpoint}/{USERNAME}/graphs/{GRAPH_ID}"
        // Update Graph EndPoint - {pixela_endpoint}/{USERNAME}/graphs/{GRAPH_ID}/{today.strftime('%Y%m%d')}
        // Delete Graph EndPoint - {pixela_endpoint}/{USERNAME}/graphs/{GRAPH_ID}/{today.strftime('%Y%m%d')}
    }
}
