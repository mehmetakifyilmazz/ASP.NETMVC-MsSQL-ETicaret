using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Mwear.MvcWebUI.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Mwear.MvcWebUI.Entity
{
    public class DataContext:IdentityDbContext<ApplicationUser>
    {
        public DataContext():base("dataConnection")
        {
           
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
         public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrdersLines { get; set;}
        
    }
}