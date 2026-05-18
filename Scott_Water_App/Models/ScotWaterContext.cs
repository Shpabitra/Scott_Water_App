using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Scott_Water_App.Models;

namespace Scott_Water_App.Models
{
    public class ScotWaterContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Businesses> Businesses { get; set; }
        public DbSet<Readings> Readings { get; set; }
        public DbSet<WaterLevel> WaterLevels { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Price> Prices { get; set; }

        public ScotWaterContext() : base("ScotWaterConnection")
        {
            // Specify the type explicitly
            Database.SetInitializer<ScotWaterContext>(new ScotWaterDatabaseInitialiser());
        }
    }
}
public class ScotWaterDatabaseInitialiser
       : DropCreateDatabaseAlways<ScotWaterContext>
{
    protected override void Seed(ScotWaterContext context)
    {
        base.Seed(context);
        var businesses1 = new Businesses
        {
            BusinessName = "Tesco",
            BusinessEmail = "TescoCompany@test.com",
            BusinessContactNumber = "0123456789",
            BusinessCity = "Glasgow",
            BusinessPostcode = "GL23 7PT",
            ContactPerson = "John Smith",
            RegistrationDate = DateTime.Now.ToString(),
            Status = "Active"
        };

        var businesses2 = new Businesses
        {
            BusinessName = "Costa",
            BusinessEmail = "Costa@test.com",
            BusinessContactNumber = "0987654321",
            BusinessCity = "Edinburgh",
            BusinessPostcode = "ED26 9TL",
            ContactPerson = "Jane Brown",
            RegistrationDate = DateTime.Now.ToString(),
            Status = "Active"
        };
        var businesses3 = new Businesses
        {
            BusinessName = "Asda",
            BusinessEmail = "Asda@test.com",
            BusinessContactNumber = "0528405269",
            BusinessCity = "Inverness",
            BusinessPostcode = "IV34 7PQ",
            ContactPerson = "Mark Rober",
            RegistrationDate = DateTime.Now.ToString(),
            Status = "Active"
        };
        var businesses4 = new Businesses
        {
            BusinessName = "Iceland",
            BusinessEmail = "Iceland@test.com",
            BusinessContactNumber = "6483043674",
            BusinessCity = "Skye",
            BusinessPostcode = "SK61 2WE",
            ContactPerson = "Aaron Brown",
            RegistrationDate = DateTime.Now.ToString(),
            Status = "Active"
        };
        var businesses5 = new Businesses
        {
            BusinessName = "Chase",
            BusinessEmail = "Chase@test.com",
            BusinessContactNumber = "8302386571",
            BusinessCity = "Aberdeen",
            BusinessPostcode = "AB49 1YU",
            ContactPerson = "John Burns",
            RegistrationDate = DateTime.Now.ToString(),
            Status = "Active"
        };
        var businesses6 = new Businesses
        {
            BusinessName = "HMV",
            BusinessEmail = "HMV@test.com",
            BusinessContactNumber = "6592031840",
            BusinessCity = "Ayr",
            BusinessPostcode = "AY04 4RP",
            ContactPerson = "Kyle Jones",
            RegistrationDate = DateTime.Now.ToString(),
            Status = "Active"
        };
        var businesses7 = new Businesses
        {
            BusinessName = "Greggs",
            BusinessEmail = "Greggs@test.com",
            BusinessContactNumber = "4027341945",
            BusinessCity = "Stirling",
            BusinessPostcode = "ST54 1LT",
            ContactPerson = "David Matthews",
            RegistrationDate = DateTime.Now.ToString(),
            Status = "Active"
        };

        context.Businesses.Add(businesses1);
        context.Businesses.Add(businesses2);
        context.Businesses.Add(businesses3);
        context.Businesses.Add(businesses4);
        context.Businesses.Add(businesses5);
        context.Businesses.Add(businesses6);
        context.Businesses.Add(businesses7);

        context.SaveChanges();

        // Create Readings first (IDs must match FK types)
        var reading1 = new Readings
        {
            BusinessID = businesses1.BusinessID, // Link to business with ID 1
            ReadingDate = new DateTime(2000, 01, 1),
            UsageUnits = 90,
            RecycledUnits = 10
        };

        var reading2 = new Readings
        {
            BusinessID = businesses2.BusinessID, // Link to business with ID 2
            ReadingDate = new DateTime(2000, 01, 1),
            UsageUnits = 50,
            RecycledUnits = 5
        };
        var reading3 = new Readings
        {
            BusinessID = businesses3.BusinessID, // Link to business with ID 2
            ReadingDate = new DateTime(2000, 01, 1),
            UsageUnits = 72,
            RecycledUnits = 3
        };
        var reading4 = new Readings
        {
            BusinessID = businesses4.BusinessID, // Link to business with ID 2
            ReadingDate = new DateTime(2000, 01, 1),
            UsageUnits = 21,
            RecycledUnits = 10
        };
        var reading5 = new Readings
        {
            BusinessID = businesses5.BusinessID, // Link to business with ID 2
            ReadingDate = new DateTime(2000, 01, 1),
            UsageUnits = 69,
            RecycledUnits = 15
        };
        var reading6 = new Readings
        {
            BusinessID = businesses6.BusinessID, // Link to business with ID 2
            ReadingDate = new DateTime(2000, 01, 1),
            UsageUnits = 80,
            RecycledUnits = 40
        };
        var reading7 = new Readings
        {
            BusinessID = businesses7.BusinessID, // Link to business with ID 2
            ReadingDate = new DateTime(2000, 01, 1),
            UsageUnits = 30,
            RecycledUnits = 0
        };

        context.Readings.Add(reading1);
        context.Readings.Add(reading2);
        context.Readings.Add(reading3);
        context.Readings.Add(reading4);
        context.Readings.Add(reading5);
        context.Readings.Add(reading6);
        context.Readings.Add(reading7);

        context.SaveChanges();

        var waterLevel1 = new WaterLevel
        {
            BusinessID = businesses1.BusinessID, // Link to business with ID 1
            ReservePercentage = 22,
            DateSet = DateTime.Now,
        };
        var waterLevel2 = new WaterLevel
        {
            BusinessID = businesses2.BusinessID, // Link to business with ID 2
            ReservePercentage = 30,
            DateSet = DateTime.Now,
        };
        var waterLevel3 = new WaterLevel
        {
            BusinessID = businesses3.BusinessID, // Link to business with ID 1
            ReservePercentage = 54,
            DateSet = DateTime.Now,
        };
        var waterLevel4 = new WaterLevel
        {
            BusinessID = businesses4.BusinessID, // Link to business with ID 1
            ReservePercentage = 18,
            DateSet = DateTime.Now,
        };
        var waterLevel5 = new WaterLevel
        {
            BusinessID = businesses5.BusinessID, // Link to business with ID 1
            ReservePercentage = 44,
            DateSet = DateTime.Now,
        };
        var waterLevel6 = new WaterLevel
        {
            BusinessID = businesses6.BusinessID, // Link to business with ID 1
            ReservePercentage = 69,
            DateSet = DateTime.Now,
        };
        var waterLevel7 = new WaterLevel
        {
            BusinessID = businesses7.BusinessID, // Link to business with ID 1
            ReservePercentage = 67,
            DateSet = DateTime.Now,
        };
        context.WaterLevels.Add(waterLevel1);
        context.WaterLevels.Add(waterLevel2);
        context.WaterLevels.Add(waterLevel3);
        context.WaterLevels.Add(waterLevel4);
        context.WaterLevels.Add(waterLevel5);
        context.WaterLevels.Add(waterLevel6);
        context.WaterLevels.Add(waterLevel7);

        context.SaveChanges();

        // Create Users and associate them with businesses/readings
        var member1 = new User
        {
            Email = "Admin1@ScotWater.com",
            Password = "Admin1",
            Role = "Admin"
        };

        var member2 = new User
        {
            Email = "JaneDoe@ScotWater.com",
            Password = "Water1",
            Role = "Staff"
        };
        var member3 = new User
        {
            Email = "SteveJobs@ScotWater.com",
            Password = "Water2",
            Role = "Staff"
        };
        var member4 = new User
        {
            Email = "Admin2@ScotWater.com",
            Password = "Admin2",
            Role = "Admin"
        };

        context.Users.Add(member1);
        context.Users.Add(member2);
        context.Users.Add(member3);
        context.Users.Add(member4);

        context.SaveChanges();

        var price1 = new Price
        {
            PriceID = 1,
            EffectiveDate = new DateTime(2026, 01, 01),
            DroughtTier1Rate = 0.47,
            DroughtTier2Rate = 0.82,
            DroughtTier3Rate = 2.25,
            NoDroughtTier1Rate = 0.41,
            NoDroughtTier2Rate = 0.64,
            NoDroughtTier3Rate = 1.35,
            RecycleRate1 = 0.05,
            RecycleRate2 = 0.15,
            RecycleRate3 = 0.25
        };

        context.Prices.Add(price1);
    }
}