using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class RegisterController : Controller
    {
        Core.Contact contact = new Core.Contact();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Register model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                Boolean IsValid = true;
                String user = model.User;
                String pass = model.Password;
                IsValid = contact.RegistrarContacto(user, pass);
                if (IsValid)
                {
                    return View("Welcome");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Por favor verifique su usuario y password que alguno no es el correcto");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "No se pudo validar, intente mas tarde");
                return View(model);
            }

        }
    }
}
