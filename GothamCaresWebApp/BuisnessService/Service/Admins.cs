using DataService.Entities;
using DataService.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BuisnessService.ServiceInterface;

namespace BuisnessService.Service

{
    public class Admins : IAdmins
    {
        private GothamContext db;

        public Admins(GothamContext gothamContext)
        {
            db = gothamContext;
        }

       
        public Admin login(string email, string password)
        {
            //Admin admin = db.Admins.Find(email);
            //if (admin == null)
            //{
            //    return "Incorrect email Address";
            //}
            //else if (!(admin.Password).Equals(password))
            //{
            //    return "Incorrect Password";
            //}
            //else 
            //{
            //    return "Login Success";
            //}

            return db.Admins.Find(email);
        }
    }
}
