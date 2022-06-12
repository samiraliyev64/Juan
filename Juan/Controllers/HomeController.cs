using Juan.DAL;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                Slides = _context.Slides.ToList(),
                Features = _context.Features.ToList(),
                ProductSummary = _context.ProductSummary.FirstOrDefault(),
                Products = _context.Products.ToList(),
                Banners = _context.Banners.ToList(),
                BlogSummary = _context.BlogSummary.FirstOrDefault(),
                Blogs = _context.Blogs.ToList(),
                Brands = _context.Brands.ToList(),
                NewProductSummary = _context.NewProductSummary.FirstOrDefault(),
                NewProducts = _context.NewProducts.ToList()
            };
            return View(home);
        }
    }
}
