
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BuisnessService.Service;
using BuisnessService.ServiceInterface;
using DataService.Entities;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GothamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private IAdmins Admin;

        public AdminsController(IAdmins admin)
        {
            Admin = admin;
        }

        [HttpGet("/{email}/{password}")]
        public IActionResult Login(string email, String password) 
        {
            Admin admin = Admin.login(email, password);
            if (admin == null)
            {
                return NotFound("Incorrect Email Address");
            }
            else if (!(admin.Password).Equals(password))
            {
                return NotFound("Incorrect Password");
            }
            else
            {
                return Ok("Login Success");
            }


        }

















    }
}
