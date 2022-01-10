using Allup.DATA;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class HomeController : Controller
    {

        //private readonly AppDbContext _context;

        //public HomeController(AppDbContext context)
        //{
        //    _context = context;
        //}
       
        public  IActionResult Index()
        {
            var categoryList = new List<CategoryViewModel>
            {
                new CategoryViewModel
                {
                    Name ="Laptop",
                    Image = "category-1.jpg"
                },
                 new CategoryViewModel
                {
                    Name ="Computer",
                    Image = "category-2.jpg"
                },
                  new CategoryViewModel
                {
                    Name ="Smartphone",
                    Image = "category-3.jpg"
                },
                   new CategoryViewModel
                {
                    Name ="Game Consoles",
                    Image = "category-4.jpg"
                },
                    new CategoryViewModel
                {
                    Name ="Bottoms",
                    Image = "category-5.jpg"
                },
                     new CategoryViewModel
                {
                    Name ="Tops&Sets",
                    Image = "category-6.jpg"
                },
                      new CategoryViewModel
                {
                    Name ="Audio & Video",
                    Image = "category-7.jpg"
                },
                       new CategoryViewModel
                {
                    Name ="Accessories",
                    Image = "category-8.jpg"
                },
            };
            return View(categoryList);
        }

      
    }
}
