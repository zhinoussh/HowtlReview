﻿namespace HotelAdvice.Migrations
{
    using HotelAdvice.Areas.Admin.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Config_ProjectDB : DbMigrationsConfiguration<HotelAdvice.HotelAdviceDB>
    {
        public Config_ProjectDB()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HotelAdvice.HotelAdviceDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            


        }
    }
}
