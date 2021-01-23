using BuisnessService.ServiceInterface;
using DataService.Data;
using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessService.Service
{
    class Outlets : IOutlets
    {
        private GothamContext db;

        public Outlets(GothamContext db)
        {
            this.db = db;
        }

        public List<Outlet> GetOutlets()
        {
            return db.Outlets.ToList();
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

        public String EditOutletDetails(Outlet Outlet)
        {
            var id = Outlet.OutletId;
            Outlet toChange = db.Outlets.Find(id);
            if (toChange == null)
            {
                return $"Outlet with OutletId = {toChange.OutletId} does not exist";
            }
            db.Outlets.Remove(toChange);
            db.Outlets.Add(Outlet);
            db.SaveChanges();

            return "Outlet Details Edited Successfully";
        }



    }
}
