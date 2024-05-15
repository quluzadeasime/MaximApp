using Business.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaximNLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceService _serviceService;

		public HomeController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		public IActionResult Index()
        {
            var service = _serviceService.GetAllService();
            return View(service);
        }

    }
}
