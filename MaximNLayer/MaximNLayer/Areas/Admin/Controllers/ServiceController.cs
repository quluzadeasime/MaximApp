using Business.Services.Abstracts;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaximNLayer.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ServiceController : Controller
	{
		private readonly IServiceService _serviceService;

		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		public IActionResult Index()
		{
			var services = _serviceService.GetAllService();
			return View(services);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Service service)
		{
			return View();
		}
	}
}
