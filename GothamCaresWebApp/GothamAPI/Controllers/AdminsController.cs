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

        public AdminsController()
        {
            Volunteers.Add(new Volunteers() { Id = 1, Name = "Muhsina Binth", Phone = 869624448, email = "muhsinabinth@gmail.com", OutletId = 2 });
            Volunteers.Add(new Volunteers() { Id = 2, Name = "Muhsina", Phone = 860624448, email = "muhsina@gmail.com", OutletId = 1 });
        }

        [HttpGet]
        [Route("VolunteersList")]
        public List<Volunteers> Get()
        {

            return Volunteers;

        }

        // POST api/<AdminsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdminsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
