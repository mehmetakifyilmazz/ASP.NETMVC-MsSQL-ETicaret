 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mwear.MvcWebUI.Entity;
using System.Data.SqlClient;
using Mwear.MvcWebUI.Models;
using Microsoft.Identity.Client;

namespace Mwear.MvcWebUI.Controllers
{ 
    public class HomeController : Controller
    {
        readonly DataContext _context=new DataContext();  
        // GET: Home
        public ActionResult Index()
        {
            var urunler =_context.Products
                .Where(i=> i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id= i.Id,
                    Name= i.Name,
                    Description= i.Description,
                    
                    Stock= i.Stock,
                    Image= i.Image,
                    CategoryId= i.CategoryId,

                }).ToList();
            return View(urunler);
        }
        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id==id).FirstOrDefault());
        }
        public ActionResult List(int? id)
        {
            var urunler = _context.Products
               .Where(i => i.IsApproved)
               .Select(i => new ProductModel()
               {
                   Id = i.Id,
                   Name = i.Name,
                   Description = i.Description,
                  
                   Stock = i.Stock,
                   Image = i.Image,
                   CategoryId = i.CategoryId,

               }).AsQueryable();
            if (id!=null)
            {
                urunler=urunler.Where(i => i.CategoryId==id);
            }

            return View(urunler);

            

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public PartialViewResult GetCategories()
            {
                return PartialView(_context.Categories.ToList());
            }
        }
    }
