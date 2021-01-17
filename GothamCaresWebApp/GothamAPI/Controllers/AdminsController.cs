using BuisnessServices.Data;
using BuisnessServices.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;

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
        [ResponseType(typeof(Outlet))]
        public IHttpActionResult DeleteOutlet(int id) 
        {
            Outlet outlet = db.Outlets.Find(id);
            return Ok(outlet);
        }


    }
}
