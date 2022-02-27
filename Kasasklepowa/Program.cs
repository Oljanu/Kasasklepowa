using System;

namespace Kasasklepowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopService service = new ShopService();
            foreach (var product in service.Warehouse)
            {
                Console.WriteLine($"{product.Barcode}   {product.Name}  {product.NettoPrice} zł netto   {product.BruttoPrice} zł brutto");
            }
            Console.ReadLine();

        }
        
    
        
    }

    
}
