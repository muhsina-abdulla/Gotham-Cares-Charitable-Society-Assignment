using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BuisnessServices.Entities
{
    public class OutletsPerDate
    {
        [Key]
        public String Date { get; set; }
        public List<Outlet> Outlets { get; set; } = new List<Outlet>();
    }
}
