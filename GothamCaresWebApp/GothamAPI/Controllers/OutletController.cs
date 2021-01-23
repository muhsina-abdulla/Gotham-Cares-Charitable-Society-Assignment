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
        // GET: api/<OutletController>

        [HttpGet]
        [Route("Outlets")]
        public IActionResult GetOutlets()
        {
            return Ok(Outlets.GetOutlets());
        }


        [HttpPost("New Outlet")]
        public IActionResult AddOutlet(Outlet Outlet)
        {

            return Ok(Admin.AddOutlet(Outlet));

        }

        [HttpPut("Edit Outlet/{id}")]
        public IActionResult EditOutlet(Outlet Outlet)
        {
            String result = Admin.EditOutletDetails(Outlet);
            if (result.Equals("Outlet Details Edited Successfully"))
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpDelete("Delete Outlet/{id}")]
        public IActionResult DeleteOutlet(int id)
        {
            string result = Admin.DeleteOutlet(id);
            if (result.Equals("Deletion Successful"))
            {
                return Ok(result);
            }
            return NotFound(result);
        }


    }
}
