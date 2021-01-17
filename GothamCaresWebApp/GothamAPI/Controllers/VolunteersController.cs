using BuisnessServices.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuisnessServices.Services;



namespace GothamAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class VolunteersController : ControllerBase
    {
        private IVolunteer Volunteer;

        public VolunteersController(IVolunteer volunteer)
        {
            Volunteer = volunteer;
        }


        [HttpPost]
        [Route("Registration")]
        public IActionResult Register(Volunteers Vol) 
        {
            return Ok(Volunteer.VolunteerRegister(Vol));

        }

        [HttpGet]
        [Route("Outlets")]
        public IActionResult GetOutlets()
        {
            return Ok(Volunteer.GetOutlets());
        }
    }
}
