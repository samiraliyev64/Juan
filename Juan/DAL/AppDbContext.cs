﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juan.Models;
using Microsoft.EntityFrameworkCore;


namespace Juan.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ProductSummary> ProductSummary { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BlogSummary> BlogSummary { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<NewProductSummary> NewProductSummary { get; set; }
        public DbSet<NewProduct> NewProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
    }
}
