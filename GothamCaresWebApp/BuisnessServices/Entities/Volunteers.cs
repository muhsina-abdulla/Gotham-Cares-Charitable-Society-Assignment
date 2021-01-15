using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessServices.Entities
{
    public class Volunteers
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int Phone { get; set; }
        public string email { get; set; }
        public Outlet Outlet { get; set; } = new Outlet();
        public String Date { get ; set; }



    }
}
