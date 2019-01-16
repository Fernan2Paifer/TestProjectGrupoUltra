using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebClient.Models;
using WebClient.Services;

namespace WebClient.Controllers
{
[Authorize]
public class HomeController : Controller
	{
	private readonly ProviderIdentityToken _tokenProvider;
	private readonly UserManager<ApplicationUser> _userManager;

	public HomeController(ProviderIdentityToken tokenProvider, UserManager<ApplicationUser> userManager)
		{
		_tokenProvider = tokenProvider;
		_userManager = userManager;
		}
	public async Task<IActionResult> IndexAsync()
		{
		var userId = _userManager.GetUserId(HttpContext.User);
		var Employee = new ReporteTrabajadores();
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

		Employee = Reporte.Where(a => a.Employee.FkUser == userId).FirstOrDefault();


		return View(Employee);
		}

	public IActionResult About()
		{


		ViewData["Message"] = "Your application description page.";

		return View();
		}

	public IActionResult Contact()
		{
		ViewData["Message"] = "Your contact page.";

		return View();
		}

	public IActionResult Error()
		{
		return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
		}
	}
}
