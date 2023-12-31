﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.Concrete
{
    public class CarBookContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-6NNQ5EJI\\KEREM;initial catalog=CarBookDB;integrated Security=true");
        }

        public DbSet<CarDetail> CarDetails { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CarStatus> CarStatuses { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<HowItWorksStep> HowItWorksSteps { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Contact2> Contacts2 { get; set; }  

    }
}
