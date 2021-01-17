using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessServices.Entities
{
    public class Volunteers
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public long Phone { get; set; }
        public string email { get; set; }

        public int OutletId { get; set; }
        public String Date { get ; set; }



    }
}
