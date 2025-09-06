using System;
using System.Linq;
using System.Xml.Linq;

public class TransformationOperators
{

    public static void Question1()
    {
        var products = ListGenerators.GetProducts().Select(p => p.ProductName);

        Console.WriteLine("Product Names:");
        foreach (var p in products)
            Console.WriteLine(p);
    }

    public static void Question2()
    {
        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        var result = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });

        Console.WriteLine("Upper & Lower:");
        foreach (var item in result)
            Console.WriteLine($"{item.Upper} - {item.Lower}");
    }

    public static void Question3()
    {
        var products = ListGenerators.GetProducts()
            .Select(p => new { p.ProductName, Price = p.UnitPrice });

        Console.WriteLine("Products with price:");
        foreach (var p in products)
            Console.WriteLine($"{p.ProductName} - {p.Price}");
    }

    public static void Question4()
    {
        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        Console.WriteLine("Number : In-Place?");
        var result = Arr.Select((value, index) => new { value, index, match = (value == index) });
        foreach (var item in result)
            Console.WriteLine($"{item.value} : {item.match}");
    }

    public static void Question5()
    {
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };

        var pairs = from a in numbersA
                    from b in numbersB
                    where a < b
                    select new { a, b };

        Console.WriteLine("Pairs where a < b :");
        foreach (var p in pairs)
            Console.WriteLine($"{p.a} is less than {p.b}");
    }

    public static void Question6()
    {
        var customers = XDocument.Load("Customers.xml")
            .Descendants("order")
            .Where(o => (decimal?)o.Element("total") < 500)
            .Select(o => new
            {
                ID = (string?)o.Element("id") ?? "N/A",
                Total = (decimal?)o.Element("total") ?? 0
            });

        Console.WriteLine("Orders with total < 500:");
        foreach (var o in customers)
            Console.WriteLine($"{o.ID} - {o.Total}");
    }

    public static void Question7()
    {
        var customers = XDocument.Load("Customers.xml")
            .Descendants("order")
            .Where(o =>
            {
                var dateStr = (string?)o.Element("orderdate");
                if (DateTime.TryParse(dateStr, out DateTime date))
                    return date.Year >= 1998;
                return false;
            })
            .Select(o => new
            {
                ID = (string?)o.Element("id") ?? "N/A",
                Date = DateTime.TryParse((string?)o.Element("orderdate"), out DateTime d) ? d : DateTime.MinValue
            });

        Console.WriteLine("Orders in 1998 or later:");
        foreach (var o in customers)
            Console.WriteLine($"{o.ID} - {(o.Date == DateTime.MinValue ? "Invalid Date" : o.Date.ToShortDateString())}");
    }
}
