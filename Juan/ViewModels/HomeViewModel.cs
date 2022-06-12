using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class HomeViewModel
    {
        public List<Slide> Slides { get; set; }
        public List<Feature> Features { get; set; }
        public ProductSummary ProductSummary { get; set; }
        public List<Product> Products { get; set; }
        public List<Banner> Banners { get; set; }
        public BlogSummary BlogSummary { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Brand> Brands { get; set; }
        public NewProductSummary NewProductSummary { get; set; }
        public List<NewProduct> NewProducts { get; set; }
    }
}
