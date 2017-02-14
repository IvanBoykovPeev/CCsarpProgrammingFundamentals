using System;
using System.Linq;

namespace _07.SalesReport
{
    class Program
    {
        static void Main()
        {
            Sale[] sales = Sale.ReadSales();
            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t);
            foreach (var town in towns)
            {
                decimal salesByTowns = sales.Where(s => s.Town == town).Select(s => s.Price * s.Quantity).Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesByTowns);
            }
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public static Sale ReadSale()
        {
            Sale sale = new Sale();
            string[] saleInfo = Console.ReadLine().Split().ToArray();
            sale.Town = saleInfo[0];
            sale.Product = saleInfo[1];
            sale.Price = decimal.Parse(saleInfo[2]);
            sale.Quantity = decimal.Parse(saleInfo[3]);
            return sale;
        }

        public static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }
    }
}
