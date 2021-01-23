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

            modelBuilder.Entity<Outlet>().HasData(
              new Outlet
              {
                  OutletId = 1,
                  Name = "Rose",
                  Street = "ABC",
                  Landmark = "ABC Store",
                  FoodPackets = 78,
                  FoodType = FoodType.NonVeg,
                  RequiredVolunteers = 7,
                  Date = "21/01/2020"
              }
              ,new Outlet
              {
                  OutletId = 2,
                  Name = "Lily",
                  Street = "DEF",
                  Landmark = "DEF Store",
                  FoodPackets = 100,
                  FoodType = FoodType.Veg,
                  RequiredVolunteers = 10,
                  Date = "22/01/2020"

              }

             , new Outlet
             {
                 OutletId = 3,
                 Name = "Jasmine",
                 Street = "GHI",
                 Landmark = "GHI Store",
                 FoodPackets = 110,
                 FoodType = FoodType.Both,
                 RequiredVolunteers = 11,
                 Date = "23/01/2020"
             }, new Outlet
             {

                 OutletId = 4,
                 Name = "Lavender",
                 Street = "JKL",
                 Landmark = "JKL Store",
                 FoodPackets = 200,
                 FoodType = FoodType.Both,
                 RequiredVolunteers = 20,
                 Date = "24/01/2020"

             }, new Outlet
             {

                 OutletId = 5,
                 Name = "Orchid",
                 Street = "MNO",
                 Landmark = "MNO Store",
                 FoodPackets = 400,
                 FoodType = FoodType.Veg,
                 RequiredVolunteers = 40,
                 Date = "25/01/2020"

             }
            ) ;


            modelBuilder.Entity<Volunteers>().HasData(new Volunteers
            {
                Id = 1,
                Name = "Muhsina",
                Phone = 86066244485,
                email = "muhsinabinthabdulla@gmail.com",
                OutletId = 1,



            }, new Volunteers
            {
                Id = 2,
                Name = "Hepzibha",
                Phone = 98204928902,
                email = "Hepzibha@gmail.com",
                OutletId = 2,


            }, new Volunteers
            {
                Id = 3,
                Name = "Priya",
                Phone = 5864564025,
                email = "Prya@gmail.com",
                OutletId = 3,

            }, new Volunteers
            {
                Id = 4,
                Name = "Megha",
                Phone = 89208374890,
                email = "Megha@gmail.com",
                OutletId = 4,

            }, new Volunteers
            {
                Id = 5,
                Name = "Navneeth",
                Phone = 9820328902,
                email = "FantomPhreak@gmail.com",
                OutletId = 5,

            }
            ); 

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
