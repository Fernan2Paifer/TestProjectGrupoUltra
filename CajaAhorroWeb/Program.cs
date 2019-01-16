using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CajaAhorroWeb
{
    public class Program
    {
        //        public static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();


        //        private static async Task MainAsync()
        //        {
        //            var disco = await DiscoveryClient.GetAsync("http://localhost:5000");

        //            if (disco.IsError)
        //            {
        //                throw new Exception("error");
        //            }

        //            var TokenCliente = new TokenClient(disco.TokenEndpoint, "ClientApiCajaAhorro", "Test123*");
        //            var TokenResponse = await TokenCliente.RequestClientCredentialsAsync("resourceApiCajaAhorro");

        //            if (TokenResponse.IsError)
        //            {
        //                throw new Exception("error");
        //            }

        //            var TokenJson = TokenResponse.Json;


        //            //A partir de aqui hacemos la llamada a nuestra API

        //            var client = new HttpClient();
        //            //specify to use TLS 1.2 as default connection
        //            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

        //            client.SetBearerToken(TokenResponse.AccessToken);

        //            var response = await client.GetAsync("https://localhost:44397/api/values");

        //            if (!response.IsSuccessStatusCode)
        //            {
        //                throw new Exception("error");
        //            }
        //            else
        //            {
        //                var content = await response.Content.ReadAsStringAsync();

        //            }


        //        }
        //    }
        //}

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
