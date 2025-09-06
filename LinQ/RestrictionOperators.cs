using System;
using System.Linq;

public class RestrictionOperators
{
    #region Q1
    public static void Question1()
    {
        var products = ListGenerators.GetProducts();
        var result = products.Where(p => p.UnitsInStock == 0);

        Console.WriteLine("Products out of stock:");
        foreach (var p in result)
            Console.WriteLine($"{p.ProductName}");
    }
    #endregion

    #region Q2

    public static void Question2()
    {
        var products = ListGenerators.GetProducts();
        var result = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

        Console.WriteLine("Products in stock and cost > 3:");
        foreach (var p in result)
            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
    }
    #endregion

    #region Q3

    public static void Question3()
    {
        string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var result = Arr.Select((name, value) => new { name, value })
                        .Where(x => x.name.Length < x.value);

        Console.WriteLine("Digits with name shorter than value:");
        foreach (var item in result)
            Console.WriteLine($"{item.name} ({item.value})");
    }

    #endregion
}
