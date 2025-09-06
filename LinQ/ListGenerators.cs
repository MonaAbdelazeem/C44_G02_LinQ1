using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public string ProductName { get; set; }
    public string Category { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

public static class ListGenerators
{
    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
            new Product { ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00m, UnitsInStock = 17 },
            new Product { ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 13 },
            new Product { ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.00m, UnitsInStock = 53 },
            new Product { ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.35m, UnitsInStock = 0 },
            new Product { ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25.00m, UnitsInStock = 120 },
            new Product { ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30.00m, UnitsInStock = 15 },
            new Product { ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40.00m, UnitsInStock = 6 },
            new Product { ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.00m, UnitsInStock = 29 }
        };
    }
}

