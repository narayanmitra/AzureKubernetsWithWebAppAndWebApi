using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp
{
    public class ServiceRepository
    {
        public HttpClient Client { get; set; }
        IConfiguration configuration;
        public ServiceRepository(IConfiguration _configuration)
        {
            configuration = _configuration;
            //var serviceUrl = Environment.GetEnvironmentVariable("serviceUrl");
            var serviceUrl = configuration["ServiceUrl"];
            Client = new HttpClient();
            Client.BaseAddress = new Uri(serviceUrl.ToString());
        }
        public HttpResponseMessage GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }
    }
}
