namespace SweetTooth.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SweetTooth.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SweetTooth.Models.ApplicationDbContext context)
        {
            //AddSomeRoles(context);
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

        private void AddSomeRoles(ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "Admin" });
            }
            if (!context.Roles.Any(r => r.Name == "Client"))
            {
                context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "Client" });
            }
        }
   }
}
