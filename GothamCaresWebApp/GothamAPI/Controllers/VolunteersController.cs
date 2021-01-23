using DataService.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService.Services;



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

        [HttpGet]
        [Route("Volunteers List")]
        public IActionResult GetVolunteers()
        {

            return Ok(Admin.GetVolunteers());

        }


        [HttpPost]
        [Route("Volunteer Registration")]
        public IActionResult Register(Volunteers Vol) 
        {
            return Ok(Volunteer.VolunteerRegister(Vol));

        }

        
    }
}
