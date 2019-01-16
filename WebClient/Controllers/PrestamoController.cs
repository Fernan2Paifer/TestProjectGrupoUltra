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
public class PrestamoController : Controller
	{
	private readonly ProviderIdentityToken _tokenProvider;
	public PrestamoController(ProviderIdentityToken tokenProvider)
		{
		_tokenProvider = tokenProvider;
		}
	[HttpGet]
	public async Task<IActionResult> PrestamosByTrabajador(int? IdTrabajador)
		{
		var Prestamos = new List<Prestamo>();
		var client = new HttpClient();
		//specify to use TLS 1.2 as default connection
		System.Net.ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
		client.SetBearerToken(_tokenProvider.getProviderIdentityToken().AccessToken);
		var response =
			await client.GetAsync("http://localhost/ApiCajaAhorro/api/EPrestamoes/GetPrestamosByTrabajador?idTrab=" +
			                      IdTrabajador);

		if (!response.IsSuccessStatusCode)
			{
			throw new Exception("error");
			}
		else
			{
			var content = await response.Content.ReadAsStringAsync();
			Prestamos = JsonConvert.DeserializeObject<List<Prestamo>>(content);
			}
		ViewBag.IdTrabajador = IdTrabajador;
		return View(Prestamos);
		}
	public async Task<IActionResult> DetailPrestamoTrabajador(int IdTrabajador)
		{
		var Reporte = new Employee();
		var client = new HttpClient();
		//specify to use TLS 1.2 as default connection
		System.Net.ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
		client.SetBearerToken(_tokenProvider.getProviderIdentityToken().AccessToken);
		var response = await client.GetAsync("http://localhost/ApiCajaAhorro/api/ETrabajadors/" + IdTrabajador);

		if (!response.IsSuccessStatusCode)
			{
			throw new Exception("error");
			}
		else
			{
			var content = await response.Content.ReadAsStringAsync();
			Reporte = JsonConvert.DeserializeObject<Employee>(content);
			}
		ViewBag.Employee = Reporte;
		ViewBag.IdTrabajador = IdTrabajador;
		return View();
		}
	public async Task AceptarPrestamo(int IdTrabajador, int monto)
		{
		var client = new HttpClient();
		//specify to use TLS 1.2 as default connection
		System.Net.ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
		client.SetBearerToken(_tokenProvider.getProviderIdentityToken().AccessToken);
		var response =
			await client.GetAsync("http://localhost/ApiCajaAhorro/api/EPrestamoes/AceptarPrestamo?IdTrabajador=" +
			                      IdTrabajador + "&monto=" + monto);

		if (!response.IsSuccessStatusCode)
			{
			throw new Exception("error");
			}
		}
	[HttpGet]
	public async Task<int> SolicitarPrestamo(int? IdTrabajador, int monto)
		{
		var Prestamo = 0;
		var client = new HttpClient();
		//specify to use TLS 1.2 as default connection
		System.Net.ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
		client.SetBearerToken(_tokenProvider.getProviderIdentityToken().AccessToken);
		var response = await client.GetAsync("http://localhost/ApiCajaAhorro/api/ETrabajadors/SolicitarPrestamo/" +
		                                     IdTrabajador + "/" + monto);

		if (!response.IsSuccessStatusCode)
			{
			throw new Exception("error");
			}
		else
			{
			var content = await response.Content.ReadAsStringAsync();
			Prestamo = JsonConvert.DeserializeObject<int>(content);
			}
		return Prestamo;
		}
	}
}