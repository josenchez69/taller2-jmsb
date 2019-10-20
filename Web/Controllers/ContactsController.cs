using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [Authorize]
    public class ContactsController : Controller
    {       
        Data.Contact C1 = new Data.Contact();
        Core.Registrar registro = new Core.Registrar();
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        
        // POST: api/Contacts
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Models.Contact contact)
        {
            registro.RegistrarCont(contact.LastName, contact.Name, contact.Email, contact.Address, contact.City, contact.Phone);
            C1.Add(registro);
            return View("Thanks");
        //   return CreatedAtAction("GetContact", new { id = contact.Id }, contact);
        }
    }
}
