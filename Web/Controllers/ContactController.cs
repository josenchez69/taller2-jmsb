using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Core;
using Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        Core.Registrar registro = new Core.Registrar();
       // Data.Contact C1;
        // POST api/values
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]  
        public void Post([FromBody]Models.Contact contact)
        {
            registro.RegistrarCont(contact.LastName, contact.Name, contact.Email, contact.Address, contact.City, contact.Phone);
         //   C1.Add(registro);
        }
    }
}
