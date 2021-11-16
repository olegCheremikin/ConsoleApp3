using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace ConsoleApp3._2
{
    public class Product
    {
        public string name { get; set; }
        public int code { get; set; }
        public decimal price { get; set; }
        public Product(string name, int code, decimal price)
        {
            this.name = name;
            this.code = code;
            this.price = price;
        }
    }
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using (FileStream fs = new FileStream("Products.json", FileMode.Open))
            {
                Product restoredProduct = await JsonSerializer.DeserializeAsync<Product>(fs);
                Console.ReadKey();
            }
        }
    }
}
