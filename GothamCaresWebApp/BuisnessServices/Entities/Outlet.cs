﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessServices.Entities
{
    public class Outlet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Landmark { get; set; }
        public int FoodPackets { get; set; }
        public string FoodType { get; set; }
        public int RequiredVolunteers { get; set; }
        //public List<DateTime> Dates { get; set; } = new List<DateTime>();

    }
}
