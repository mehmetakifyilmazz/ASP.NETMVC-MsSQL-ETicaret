using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mwear.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var kategoriler = new List<Category>()

            {
                new Category() { Name = "Tshirt", Description = "Tshirt Ürünleri"},
                new Category() { Name = "Sweat", Description = "Sweat Ürünleri" },
                new Category() { Name = "Outwear", Description = "Outwear Ürünleri"}

            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()

            {

            new Product()

            { Name = "İtalya Oversize",
                Description = "...",
              
                Stock = 1200,
                IsApproved = true,
                CategoryId = 1,
                IsHome = true,
                Image = "italya---oversize-8b99-6.jpg"
            },


            new Product()
            {
                Name = "Boga Sweat",
                Description = "...",
               
                Stock = 1200,
                IsApproved = true,

                CategoryId = 2,
                IsHome = true,
                Image = "efsane-pl-hoodie-1-4a49.jpg"
            },

            new Product()
            {
                Description = "...",
                Name = "Napoli Ceket",
             
                Stock = 1200,
                IsApproved = true,
                CategoryId = 3,
                IsHome = true,
                Image = "napoli-ceket-b50d.jpg"

            }
            };
            new Product()

            {
                Name = "Wolves Tshirt",
                Description = "...",

                Stock = 1200,
                IsApproved = true,
                CategoryId = 1,
                IsHome = true,
                Image = "wolves--t-shirt-8493.jpg"
            };


            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);


        }
    }
}
