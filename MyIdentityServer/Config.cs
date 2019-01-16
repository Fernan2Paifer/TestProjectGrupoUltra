using IdentityServer4.Models;
using System.Collections.Generic;

namespace MyIdentityServer
    {
    public static class Config
        {
        //Retorna la lista de clientes autorizados
        public static IEnumerable<Client> GetClients()
            {
            return new List<Client>
            {
                new Client
                {
                    
                    ClientId="ClientApiCajaAhorro",
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    ClientSecrets=
                    {
                        new Secret("Test123*".Sha256())
                    },
                    AllowedScopes={ "resourceApiCajaAhorro" }
                },
            };
            }//End GetClients()

        //Retorna la lista de los recursos disponibles de la api
        public static IEnumerable<ApiResource> GetApiResources()
            {

            return new List<ApiResource>
            {
                new ApiResource("resourceApiCajaAhorro", "My resourses for ApiCajaAhorro")
            };
            }//end GetApiResources()

        }
    }
