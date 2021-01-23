using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataService.Entities
{
    public class Admin
    {
        [Key]
        public String Email { get; set; }
        public String Password { get; set; }
    }
}
