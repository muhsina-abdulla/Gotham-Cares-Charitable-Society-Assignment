using BuisnessServices.Entities;
using BuisnessServices.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BuisnessServices.Services
{
    public class AdminRepository : IAdmin
    {
        private GothamContext db;

        public AdminRepository(GothamContext gothamContext)
        {
            db = gothamContext;
        }

        public string AddOutlet(Outlet Outlet)
        {
            db.Outlets.Add(Outlet);
            db.SaveChanges();
            return "Outlet Added Successfully";
        }

        public String DeleteOutlet(int id)
        {
            Outlet outlet = db.Outlets.Find(id);
            if (outlet == null) 
            {
                return "Outlet Not Found";
            }
            db.Outlets.Remove(outlet);
            db.SaveChanges();

            return "Deletion Successful";
        }

        public void EditOutletDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<Volunteers> GetVolunteers()
        {
            return db.Volunteers.ToList();
        }
    }
}
