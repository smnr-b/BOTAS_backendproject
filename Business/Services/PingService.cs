using Business.Abstraction.Services;
using DataAccess.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PingService : IPingService
    {
        public async Task<List<Ping>> GetAll()
        {
            try
            {
                List<Ping> ping = new List<Ping>();
                string url = "http://10.50.10.14:81/PingList";
                Uri baseURL = new Uri(url);
                RestClient client = new RestClient(baseURL);
                RestRequest request = new RestRequest(baseURL, Method.Get);
                var response = await client.ExecuteAsync<List<Ping>>(request);
                var Ping = JsonConvert.DeserializeObject<List<Ping>>(response.Content);
                return Ping;
            }
            catch (Exception x)
            {

                throw x;
            }
           
        }

    }
}
