using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using aspnet_core_mvc_bootstrap_switch.Models;
using aspnet_core_mvc_bootstrap_switch.Repositories;
using System.Collections.Generic;
using aspnet_core_mvc_bootstrap_switch.ViewModels;

namespace aspnet_core_mvc_bootstrap_switch.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOccupationGroupRepository _occGroupRepo;

        public HomeController(IOccupationGroupRepository occGroupRepo) {
            _occGroupRepo = occGroupRepo;
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel {
                OccupationGroups = _occGroupRepo.FindAll()
            };
             
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
