using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Scott_Water_App.Models;

namespace Scott_Water_App.Models
{
    public class ScotWaterContext : DbContext
    {
        //Users reprents the users within the database
        public DbSet<User> Users { get; set; }

        //Users reprents the business within the database
        public DbSet<Businesses> Businesses { get; set; }

        //Users reprents the meters within the database
        public DbSet<Readings> Meters { get; set; }
        public DbSet<WaterLevel> WaterLevel { get; set; }


        public ScotWaterContext() : base("ScotWaterConnection")
        {
            Database.SetInitializer(new ScotWaterDatabaseInitialiser());
        }

       
            // Seed initial data if necessary
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure the relationships between entities
            modelBuilder.Entity<User>()
                .HasRequired(u => u.Readings)
                .WithMany()
                .HasForeignKey(u => u.BusinessID)
                .WillCascadeOnDelete(false); // Prevent cascade delete to avoid deleting related readings when a user is deleted
           
            //Turn off cascade delete fo user business relationships.
            modelBuilder.Entity<User>()
                .HasRequired(u => u.Businesses)
                .WithMany()
                .HasForeignKey(u => u.BusinessID)
                .WillCascadeOnDelete(false); // Prevent cascade delete to avoid deleting related businesses when a user is deleted
           
            base.OnModelCreating(modelBuilder);
        }
    }//End of ScotWaterContext class

    public class ScotWaterDatabaseInitialiser : DropCreateDatabaseAlways<ScotWaterContext>
    {
        protected override void Seed(ScotWaterContext context)
        {
            base.Seed(context);

            // Create Readings first (IDs must match FK types)
            var reading1 = new Readings
            {
                MeterID = 1,
                WaterUsed = 1500,
                WaterRecycled = 500
            };

            var reading2 = new Readings
            {
                MeterID = 2,
                WaterUsed = 2000,
                WaterRecycled = 1000
            };

            context.Meters.Add(reading1);
            context.Meters.Add(reading2);
            context.SaveChanges();

            // Create businesses and link to readings via MeterID
            var businesses1 = new Businesses
            {
                BusinessName = "Tesco",
                BusinessEmail = "TescoCompany@test.com",
                BusinessContactNumber = "0123456789",
                BusinessCity = "Glasgow",
                BusinessPostcode = "GL23 7PT",
                MeterID = reading1.MeterID
            };

            var business2 = new Businesses
            {
                BusinessName = "Costa",
                BusinessEmail = "CostaCompany@test.com",
                BusinessContactNumber = "0987654321",
                BusinessCity = "Edinburgh",
                BusinessPostcode = "ED26 9TL",
                MeterID = reading2.MeterID
            };

            context.Businesses.Add(businesses1);
            context.Businesses.Add(business2);
            context.SaveChanges();

            // Create Users and associate them with businesses/readings
            var member1 = new User
            {
                Email = "member1@test.com",
                Password = "1",
                BusinessID = businesses1.BusinessID,
                MeterID = reading1.MeterID
            };

            var member2 = new User
            {
                Email = "member2@test.com",
                Password = "2",
                BusinessID = business2.BusinessID,
                MeterID = reading2.MeterID
            };

            context.Users.Add(member1);
            context.Users.Add(member2);
            context.SaveChanges();
        }

        //THIS IS A TEST TO SEE IF GITHUB WORKS!!!!!!

    }//End of ScotWaterDatabaseInitialiser class
}//End of Namespace

    

