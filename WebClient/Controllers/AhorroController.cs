using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Services;

namespace WebClient.Controllers
{
[Authorize]
public class AhorroController : Controller
	{
	private readonly ProviderIdentityToken _tokenProvider;

	public AhorroController(ProviderIdentityToken tokenProvider)
		{
		_tokenProvider = tokenProvider;
		}
	[HttpGet]
	public async Task<IActionResult> AhorrosByTrabajador(int? IdTrabajador)
		{
		var Ahorro = new List<Ahorro>();
		var client = new HttpClient();
		//specify to use TLS 1.2 as default connection
		System.Net.ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
		client.SetBearerToken(_tokenProvider.getProviderIdentityToken().AccessToken);
		var response =
			await client.GetAsync("http://localhost/ApiCajaAhorro/api/EAhorroes/GetAhorrosByTrabajador?idTrab=" +
			                      IdTrabajador);

		if (!response.IsSuccessStatusCode)
			{
			throw new Exception("error");
			}
		else
			{
			var content = await response.Content.ReadAsStringAsync();
			Ahorro = JsonConvert.DeserializeObject<List<Ahorro>>(content);

			}

		ViewBag.IdTrabajador = IdTrabajador;
		return View(Ahorro);
		}
	public async Task AddAhorro(int IdTrabajador, int monto)
		{
		var client = new HttpClient();
		//specify to use TLS 1.2 as default connection
		System.Net.ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
		client.SetBearerToken(_tokenProvider.getProviderIdentityToken().AccessToken);
		var response = await client.GetAsync("http://localhost/ApiCajaAhorro/api/EAhorroes/AddAhorro?IdTrabajador=" +
		                                     IdTrabajador + "&monto=" + monto);

		if (!response.IsSuccessStatusCode)
			{
			throw new Exception("error");
			}


		}
	}
}