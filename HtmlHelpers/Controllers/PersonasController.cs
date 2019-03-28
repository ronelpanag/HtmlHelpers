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

        public IActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Persona persona)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Resultado", persona);
            }
            else
            {
                return View(persona);
            }
        }


        public IActionResult Resultado(Persona persona)
        {
            ViewData["Resultado"] = "Hemos recibido los siguientes datos:";
            if (persona.Hobby1)
            {
                ViewData["Hobby1"] = "Musica";
            }
            if (persona.Hobby2)
            {
                ViewData["Hobby2"] = "Tecnologia";
            }
            if (persona.Hobby3)
            {
                ViewData["Hobby3"] = "Deportes";
            }
            if (persona.Hobby4)
            {
                ViewData["Hobby4"] = "Farandula";
            }
            if(!persona.Hobby1 && !persona.Hobby2 && !persona.Hobby3 && !persona.Hobby4)
            {
                ViewData["Hobby1"] = "No tienes ningun hobby";
            }

            return View(persona);
        }
    }
}