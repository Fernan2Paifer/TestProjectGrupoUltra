using System;
using System.Threading.Tasks;
using IdentityModel.Client;

namespace WebClient.Services
{
public class ProviderIdentityToken
	{
	public static TokenResponse _tokenIdentity;
	public TokenResponse getProviderIdentityToken()
		{
		return _tokenIdentity;
		}
	public async Task MainAsync()
		{
		var disco = await DiscoveryClient.GetAsync("http://localhost/identityserver");
		if (disco.IsError) throw new Exception("error");
		var tokencliente = new TokenClient(disco.TokenEndpoint, "ClientApiCajaAhorro", "Test123*");
		var tokenResponse = await tokencliente.RequestClientCredentialsAsync("resourceApiCajaAhorro");
		if (tokenResponse.IsError) throw new Exception("error");
		_tokenIdentity = tokenResponse;
		}
	}
}
