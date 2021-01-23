﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataService.Entities
{
    public class Admin
    {
        [Key]
        [Required]
        public String Email { get; set; }
        [Required]
        public String Password { get; set; }
    }
}
