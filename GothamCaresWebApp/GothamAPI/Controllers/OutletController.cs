using BuisnessService.ServiceInterface;
using DataService.Entities;
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
    public class OutletController : ControllerBase
    {
        private IOutlets Outlets;

        public OutletController(IOutlets outlet)
        {
            Outlets = outlet;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            
            return Ok(Outlets.GetOutlets());
        }


        [HttpPost]
        public IActionResult Post(Outlet Outlet)
        {
            string str = Outlets.AddOutlet(Outlet);
            if ((str).Equals("Outlet Added Successfully"))
            {
                return Ok(str);
            }
            else
            {
                return BadRequest(str);
            }

        }

        [HttpPut("/{id}")]
        public IActionResult EditOutlet(Outlet Outlet)
        {
            String result = Outlets.EditOutletDetails(Outlet);
            if (result.Equals("Outlet Details Edited Successfully"))
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpDelete("/{id}")]
        public IActionResult DeleteOutlet(int id)
        {
            string result = Outlets.DeleteOutlet(id);
            if (result.Equals("Deletion Successful"))
            {
                return Ok(result);
            }
            return NotFound(result);
        }


    }
}
