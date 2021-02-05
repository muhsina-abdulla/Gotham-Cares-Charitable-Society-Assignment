using BuisnessService.ServiceInterface;
using DataService.Entities;
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
        private IVolunteer Volunteer;

        public VolunteersController(IVolunteer volunteer)
        {
            Volunteer = volunteer;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(Volunteer.GetVolunteers());

        }


        [HttpPost]
        
        public IActionResult Post(Volunteers Vol) 
        {
            return Ok(Volunteer.VolunteerRegister(Vol));

        }

        
    }
}
