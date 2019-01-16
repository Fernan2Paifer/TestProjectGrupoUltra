using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Services;

namespace WebClient.Controllers
{
[Authorize]
public class TrabajadorController : Controller
	{
	private readonly ProviderIdentityToken _tokenProvider;
	public TrabajadorController(ProviderIdentityToken tokenProvider)
		{
		_tokenProvider = tokenProvider;
		}
	[HttpGet]
	[Authorize(Roles = "Admin")]
	public async Task<IActionResult> ReporteTrabajadores()
		{
		var Reporte = new List<ReporteTrabajadores>();
		var client = new HttpClient();
		//specify to use TLS 1.2 as default connection
		System.Net.ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
		client.SetBearerToken(_tokenProvider.getProviderIdentityToken().AccessToken);
		var response = await client.GetAsync("http://localhost/ApiCajaAhorro/api/ETrabajadors/ReporteTrabajadores");

		if (!response.IsSuccessStatusCode)
			{
			throw new Exception("error");
			}
		else
			{
			var content = await response.Content.ReadAsStringAsync();
			Reporte = JsonConvert.DeserializeObject<List<ReporteTrabajadores>>(content);
			}
		return View(Reporte);
		}
	public async Task<IActionResult> Inscribir(int idTrabajador)
		{
		var client = new HttpClient();
		//specify to use TLS 1.2 as default connection
		System.Net.ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
		client.SetBearerToken(_tokenProvider.getProviderIdentityToken().AccessToken);
		var response =
			await client.GetAsync("http://localhost/ApiCajaAhorro/api/ETrabajadors/InscribirTrabajador/" +
			                      idTrabajador);

		if (!response.IsSuccessStatusCode)
			{
			throw new Exception("error");
			}
		return RedirectToAction("IndexAsync", "Home");
		}
	}
}