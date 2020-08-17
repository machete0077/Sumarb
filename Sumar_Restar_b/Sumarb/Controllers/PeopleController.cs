using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sumarb.Models;

namespace Sumarb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public People listar()
        {
            People person = new People
            {
                PersonID = 1,
                Name = "Enrique Arce"
            };
            return person;
        }
    }
}

