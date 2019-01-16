using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace WebClient.Controllers
{
    public class CatchAllController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public CatchAllController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {

            string webRootPath = _hostingEnvironment.WebRootPath;
         
            return File(webRootPath+$@"\index.html", "text/html");
        }
    }
}