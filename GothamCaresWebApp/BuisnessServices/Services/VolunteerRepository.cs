using BuisnessServices.Entities;
using BuisnessServices.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BuisnessServices.Services
{
    public class VolunteerRepository : IVolunteer
    {

        private GothamContext db;

        public VolunteerRepository(GothamContext gothamContext)
        {
            db = gothamContext;
        }

        public List<Outlet> GetOutlets()
        {
            return db.Outlets.ToList();
        }

        public string VolunteerRegister(Volunteers Volunteer)
        {
            db.Volunteers.Add(Volunteer);
            db.SaveChanges();
            return "Registration Successful";
        }
    }
}
