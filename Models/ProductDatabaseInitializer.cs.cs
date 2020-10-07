using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WingtipToys0.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<Product>

    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID=1,
                    CategoryName="Cars"
                },
                new Category
                {
                    CategoryID=2,
                    CategoryName="Planes"
                },
                 new Category
                {
                    CategoryID=3,
                    CategoryName="Trucks"
                },
                  new Category
                {
                    CategoryID=4,
                    CategoryName="Boats"
                },
                   new Category
                {
                    CategoryID=5,
                    CategoryName="Rockets"
                },
            };
            return categories;
        }
            private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carearly.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carfast.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carfaster.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)."
                    +"Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
            };
            return products;
        }
    }
}