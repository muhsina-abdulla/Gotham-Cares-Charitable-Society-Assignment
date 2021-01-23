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

       // public DbSet<OutletsPerDate> OutletDates { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Outlet one = new Outlet()
            {
                OutletId = 1,
                Name = "Rose",
                Street = "ABC",
                Landmark = "ABC Store",
                FoodPackets = 78,
                FoodType = "Non Veg",
                RequiredVolunteers = 7,
                Date = "19/01/2021"
            };
            Outlet two = new Outlet()
            {
                OutletId = 2,
                Name = "Lily",
                Street = "DEF",
                Landmark = "DEF Store",
                FoodPackets = 100,
                FoodType = "Veg",
                RequiredVolunteers = 10,
                Date = "18/01/2021"
            };


            modelBuilder.Entity<Outlet>().HasData(one,two
            , new Outlet
            {
                OutletId = 3,
                Name = "Jasmine",
                Street = "GHI",
                Landmark = "GHI Store",
                FoodPackets = 110,
                FoodType = "Both",
                RequiredVolunteers = 11,
                Date = "18/01/2021"
            }, new Outlet
            {

                OutletId = 4,
                Name = "Lavender",
                Street = "JKL",
                Landmark = "JKL Store",
                FoodPackets = 200,
                FoodType = "Veg",
                RequiredVolunteers = 20,
                Date = "17/01/2021"

            }, new Outlet
            {

                OutletId = 5,
                Name = "Orchid",
                Street = "MNO",
                Landmark = "MNO Store",
                FoodPackets = 400,
                FoodType = "Veg",
                RequiredVolunteers = 40,
                Date = "17/01/2021"

            }
            );


            modelBuilder.Entity<Volunteers>().HasData(new Volunteers
            {
                Id = 1,
                Name = "Muhsina",
                Phone = 86066244485,
                email = "muhsinabinthabdulla@gmail.com",
                OutletId = 1,
                Date = "15/01/2021"
                

            }, new Volunteers
            {
                Id = 2,
                Name = "Hepzibha",
                Phone = 98204928902,
                email = "Hepzibha@gmail.com",
                OutletId = 1,
                Date = "16/01/2021"

            }, new Volunteers
            {
                Id = 3,
                Name = "Priya",
                Phone = 5864564025,
                email = "Prya@gmail.com",
                OutletId = 1,
                Date = "17/01/2021"
            }, new Volunteers
            {
                Id = 4,
                Name = "Megha",
                Phone = 89208374890,
                email = "Megha@gmail.com",
                OutletId = 2,
                Date = "15/01/2021"
            }, new Volunteers
            {
                Id = 5,
                Name = "Navneeth",
                Phone = 9820328902,
                email = "FantomPhreak@gmail.com",
                OutletId = 5,
                Date = "17/01/2021"
            }
            ); ;

            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                Email = "abcd@gmail.com",
                Password="abcd"
        

            }, new Admin
            {
                Email = "efgh@gmail.com",
                Password = "efgh"

            }, new Admin
            {
                Email = "ijkl@gmail.com",
                Password = "ijkl"
            }
            );


        }
    }
}
