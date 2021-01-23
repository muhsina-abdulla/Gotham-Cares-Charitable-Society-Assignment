using DataService.Entities;
using DataService.Data;
using System.Collections.Generic;
using System.Linq;
using BuisnessService.ServiceInterface;

namespace BuisnessService.Service
{
    public class Volunteer : IVolunteer
    {

        private GothamContext db;

        public Volunteer(GothamContext gothamContext)
        {
            db = gothamContext;
        }

        
        public List<Volunteers> GetVolunteers()
        {
            return db.Volunteers.ToList();
        }

        public string VolunteerRegister(Volunteers Volunteer)
        {
            db.Volunteers.Add(Volunteer);
            db.SaveChanges();
            return "Registration Successful";
        }
    }
}
