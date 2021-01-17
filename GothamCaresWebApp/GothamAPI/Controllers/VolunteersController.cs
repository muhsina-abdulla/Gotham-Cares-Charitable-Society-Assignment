using BuisnessServices.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace GothamAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class VolunteersController : ControllerBase
    {


        public List<Outlet> Outlets { get; set; } = new List<Outlet>();

        public VolunteersController()
        {
           
        }

        [HttpPost]
        [Route("Registration")]
        public void Post()
        {


        }

        [HttpGet]
        [Route("Outlets")]
        public List<Outlet> Get()
        {
            return Outlets;
        }
    }
}
