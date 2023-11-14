using Microsoft.AspNetCore.Mvc;
using VietNameRailway.Models;
using VietNameRailway.Services;

namespace VietNameRailway.Controllers
{
    public class RailwayController : Controller
    {
        IRailwayService service;
        public RailwayController(IRailwayService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Station>? list = await service.GetAllGaBacNam();
            return View(list);
        }
        public async Task<IActionResult> ListToa()
        {
            IEnumerable<Carriages> list = await service.GetAllToaXe();
            return View(list);
        }
    }
}
