using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mwear.MvcWebUI.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Mwear.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed (IdentityDataContext context)
        {
            if (!context.Roles.Any(i =>i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
                
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);
          

            }
            if (!context.Users.Any(i => i.Name == "akifyilmaz"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "akif", Surname = "yilmaz", UserName = "akifyilmaz", Email = "makif@gmail.com"};

                manager.Create(user, "12345678");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
               

            }
            if (!context.Users.Any(i => i.Name == "bahadirakman"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "bahadir", Surname = "akman", UserName = "bahadirakman", Email = "bahadirakman@gmail.com" };

                manager.Create(user, "12345671");
                manager.AddToRole(user.Id, "user");
              

            };
            base.Seed(context);
        }
    }
}