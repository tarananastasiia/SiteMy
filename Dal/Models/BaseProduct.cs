﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal.Models
{
    public class BaseProduct
    {
        [Key]
        public int Id { get; set; }
        public int VendorCode { get; set; }
        public string ModificationArticle { get; set; }

        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Colour { get; set; }
    }
}
