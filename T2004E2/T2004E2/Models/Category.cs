﻿using System;
using System.Collections.Generic;

#nullable disable

namespace T2004E2.Models
{
    public partial class Category
    {
        public Category()
        {
            Brands = new HashSet<Brand>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
