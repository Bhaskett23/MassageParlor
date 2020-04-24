using MassageParlor.Models;
using MassageParlor.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MassageParlor.Controllers
{
    public class MassageController : Controller
    {
        IMassageService _massageService;

        public MassageController(IMassageService massageService)
        {
            _massageService = massageService;
        }

        public IActionResult Index()
        {
            IEnumerable<MassagesViewModel> massages = _massageService.GetMassages();
            return View(massages);
        }
    }
}