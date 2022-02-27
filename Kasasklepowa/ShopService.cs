using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasasklepowa
{
    public class ShopService
    {
        public ShopService ()
        {
            CreateProducts();
        }

        public List<Product> Warehouse { get; set; } = new List<Product>();

        private void CreateProduct()
        {
            Warehouse.Add(new Product("001", "Masło Ekstra", "6.5m"));
            Warehouse.Add(new Product("002", "Chleb wiejski", "4.5m"));
            Warehouse.Add(new Product("003", "Makaron Babuni", "9.2m"));
            Warehouse.Add(new Product("004", "Dżem truskawkowy", "8.1m"));
            Warehouse.Add(new Product("005", "Kiełbasa myśliwska", "29.0m"));
            Warehouse.Add(new Product("006", "Szynka konserwowa", "22.0m"));
            Warehouse.Add(new Product("007", "Chipsy paprykowe", "6.0m"));
            Warehouse.Add(new Product("008", "Serek wiejski", "3.5m"));
            Warehouse.Add(new Product("009", "Sól kuchenna", "2.7m"));
            Warehouse.Add(new Product("010", "Cukier kryształ", "3.2m"));


            //001 Masło Extra 6.50 zł
            //002 Chleb wiejski   4.50 zł
            //003 Makaron Babuni  9.20 zł
            //004 Dżem truskawkowy    8.10 zł
            //005 Kiełbasa myśliwska  29.00 zł
            //006 Szynka konserwowa   22.00 zł
            //007 Chipsy paprykowe    6.00 zł
            //008 Serek wiejski   3.50 zł
            //009 Sól kuchenna    2.70 zł
            //010 Cukier kryształ 3.20 zł



        }
    }

 }

