using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlHelpers.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Persona persona)
        {

            return View();
        }
    }
}