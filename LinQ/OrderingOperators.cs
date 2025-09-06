using System;
using System.Linq;

public class OrderingOperators
{
    public static void Question1()
    {
        var products = ListGenerators.GetProducts().OrderBy(p => p.ProductName);

        Console.WriteLine("Products sorted by name:");
        foreach (var p in products)
            Console.WriteLine(p.ProductName);
    }

    public static void Question2()
    {
        string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        var sorted = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

        Console.WriteLine("Case-insensitive sorted words:");
        foreach (var word in sorted)
            Console.WriteLine(word);
    }

    public static void Question3()
    {
        var products = ListGenerators.GetProducts().OrderByDescending(p => p.UnitsInStock);

        Console.WriteLine("Products sorted by units in stock (desc):");
        foreach (var p in products)
            Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
    }

    public static void Question4()
    {
        string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var result = Arr.OrderBy(w => w.Length).ThenBy(w => w);

        Console.WriteLine("Digits sorted by length then alphabetically:");
        foreach (var word in result)
            Console.WriteLine(word);
    }

    public static void Question5()
    {
        string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        var result = Arr.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

        Console.WriteLine("Words sorted by length then case-insensitive:");
        foreach (var word in result)
            Console.WriteLine(word);
    }

    public static void Question6()
    {
        var products = ListGenerators.GetProducts()
            .OrderBy(p => p.Category)
            .ThenByDescending(p => p.UnitPrice);

        Console.WriteLine("Products sorted by category then price (desc):");
        foreach (var p in products)
            Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
    }

    public static void Question7()
    {
        string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        var result = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

        Console.WriteLine("Words sorted by length then case-insensitive (desc):");
        foreach (var word in result)
            Console.WriteLine(word);
    }

    public static void Question8()
    {
        string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var result = Arr.Where(d => d.Length > 1 && d[1] == 'i').Reverse();

        Console.WriteLine("Digits with second letter 'i' (reversed):");
        foreach (var word in result)
            Console.WriteLine(word);
    }
}
