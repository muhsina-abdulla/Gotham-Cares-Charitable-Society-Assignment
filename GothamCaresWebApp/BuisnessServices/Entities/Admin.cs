using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuisnessServices.Entities
{
    public class Admin
    {
        [Key]
        public String Email { get; set; }
        public String Password { get; set; }
    }
}
