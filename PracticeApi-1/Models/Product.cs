using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeApi_1.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Category { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

    }
}