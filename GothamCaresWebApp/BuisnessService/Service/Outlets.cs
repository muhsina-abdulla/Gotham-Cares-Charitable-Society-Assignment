using BuisnessService.ServiceInterface;
using DataService.Data;
using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessService.Service
{
    public class Outlets : IOutlets
    {
        private GothamContext db;

        public Outlets(GothamContext db)
        {
            this.db = db;
        }

        public List<Outlet> GetOutlets()
        {
            DateTime fromdate = DateTime.Today;
            DateTime todate = DateTime.Today.AddDays(3);

            return (db.Outlets.Where(x => x.Date >= fromdate && x.Date <= todate)).OrderBy(x =>x.Date).ThenBy(x=>x.FoodType)
                .ThenBy(x=>x.Street).ToList();
        }


        public string AddOutlet(Outlet Outlet)
        {
            int count = (db.Outlets.Where(x => x.Date == Outlet.Date)).Count();
            int bothcount = (db.Outlets.Where(x => x.Date == Outlet.Date && x.FoodType == "Both")).Count();

            if((Outlet.FoodType).Equals("Both"))
            {
                if (bothcount >= 3)
                {
                    return "There are already 3 Outlets which distribute both Veg and Non Veg";
                }
            }
            if (count < 10)
            {
                db.Outlets.Add(Outlet);
                db.SaveChanges();
                return "Outlet Added Successfully";
            }
            else
            {
                return "Outlet Cannot be added.Only ten outlets allowed for a day";
            }
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
