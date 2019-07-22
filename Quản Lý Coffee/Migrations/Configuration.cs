namespace Quản_Lý_Coffee.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Quản_Lý_Coffee.Models.QuanLyCoffeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Quản_Lý_Coffee.Models.QuanLyCoffeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new QuanLyCoffeeDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new QuanLyCoffeeDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "Admin_Manager",
                Email = "XuanHieu6022@gmail.com",
                EmailConfirmed = true,

            };
            manager.Create(user, "Hieu1122");

            var user1 = new ApplicationUser()
            {
                UserName = "XuanHieu",
                Email = "XuanHieu6024@gmail.com",
                EmailConfirmed = true,

            };

            manager.Create(user1, "Hieu1122");

            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "Mod" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByName("Admin_Manager");

            manager.AddToRoles(adminUser.Id, new string[] {  "Mod","Admin" });

            var adminUser1 = manager.FindByName("XuanHieu");

            manager.AddToRoles(adminUser.Id, new string[] { "Mod" });
        }
    }
}
