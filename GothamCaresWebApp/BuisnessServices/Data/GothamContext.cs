using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BuisnessServices.Entities;

namespace BuisnessServices.Data
{
    public class GothamContext : DbContext
    {
        public GothamContext(DbContextOptions options) : base(options) {}
        public DbSet<Volunteers> Volunteers { get; set; }
        
        public DbSet<Outlet> Outlets { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<OutletsPerDate> OutletDates { get; set; }

    }
}
