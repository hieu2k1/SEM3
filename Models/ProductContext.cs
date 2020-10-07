using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingtipToys0.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingtipToys")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}