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
            return db.Admins.Find(email);
        }
    }
}
