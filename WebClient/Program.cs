//using IdentityModel.Client;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using WebClient.Services;

namespace WebClient
    {
    public class Program
        {

        public static void Main(string[] args)
            {

            var s = new ProviderIdentityToken();
            s.MainAsync().Wait();
            BuildWebHost(args).Run();
            }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }



    }
