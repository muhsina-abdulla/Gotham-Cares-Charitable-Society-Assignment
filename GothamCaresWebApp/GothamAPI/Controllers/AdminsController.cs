
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GothamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private IAdmin Admin;

        public AdminsController(IAdmin admin)
        {
            Admin = admin;
        }


       

        
       

        // PUT api/<AdminsController>/5
        

        
       
        

       
    }
}
