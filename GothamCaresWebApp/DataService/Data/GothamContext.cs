using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DataService.Entities;

namespace DataService.Data
{
    public class GothamContext : DbContext
    {
        public GothamContext(DbContextOptions options) : base(options) 
        {
        
        }
        public DbSet<Volunteers> Volunteers { get; set; }
        
        public DbSet<Outlet> Outlets { get; set; }

        public DbSet<Admin> Admins { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           

            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                Email = "muhsina-abdulla@gmail.com",
                Password="muhsina-abdulla"
        

            }, new Admin
            {
                Email = "tom-hanks@gmail.com",
                Password = "tom-hanks"

            }, new Admin
            {
                Email = "jonna-jinton@gmial.com",
                Password = "jonna-jinton"
            }
            );


        }
    }
}
