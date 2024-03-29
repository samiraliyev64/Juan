﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Summary { get; set; }
        public int Count { get; set; }
        public bool isAvailable { get; set; } = false;
        public ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
