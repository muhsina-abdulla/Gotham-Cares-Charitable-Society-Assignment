using BuisnessServices.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GothamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        public List<Volunteers> Volunteers { get; set; } = new List<Volunteers>();

       

        [HttpGet]
        [Route("VolunteersList")]
        public List<Volunteers> Get()
        {

            return Volunteers;

        }

        // POST api/<AdminsController>
        [HttpPost("New Outlet")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdminsController>/5
        [HttpPut("Edit Outlet/{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }


        [HttpDelete("Delete Outlet/{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
