using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuisnessServices.Entities
{
    public class Outlet
    {
        [Key]
        public int OutletId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Landmark { get; set; }
        public int FoodPackets { get; set; }
        public string FoodType { get; set; }
        public int RequiredVolunteers { get; set; }
        public String Date { get; set; }


    }
}
