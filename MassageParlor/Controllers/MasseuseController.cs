using System;
using System.Collections.Generic;
using AutoMapper;
using MassageParlor.Entities;
using MassageParlor.Models;
using MassageParlor.Services;
using Microsoft.AspNetCore.Mvc;

namespace MassageParlor.Controllers
{
    public class MasseuseController : Controller
    {
        private readonly IMassageService _massage;

        public MasseuseController(IMassageService massage)
        {
            _massage = massage;
        }

        public IActionResult Index()
        {
            IEnumerable<MasseuesViewModel> employees = _massage.GetEmployeesForViewing();

            return View(employees);
        }
    }
}