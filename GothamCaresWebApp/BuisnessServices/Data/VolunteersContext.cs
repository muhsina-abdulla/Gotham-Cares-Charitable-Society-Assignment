using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BuisnessServices.Entities;

namespace BuisnessServices.DataAccess
{
    public class VolunteersContext : DbContext
    {
        public VolunteersContext(DbContextOptions options) : base(options) {}
        public DbSet<Volunteers> Volunteers { get; set; }
        public int MyProperty { get; set; }


    }
}
