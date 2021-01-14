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
            Outlet item = new Outlet() { Id = 1, Name = "Outlet1", Street = "ABC Street", Landmark = "ABC", FoodPackets = 50, FoodType = "Both", RequiredVolunteers = 19 };
            Outlets.Add(item);
            item = new Outlet() { Id = 2, Name = "Outlet2", Street = "ABC Street2", Landmark = "ABC2", FoodPackets = 76, FoodType = "Veg", RequiredVolunteers = 24 };
            Outlets.Add(item);
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
