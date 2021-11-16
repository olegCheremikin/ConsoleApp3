using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace ConsoleApp3
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
            // сохранение данных
            using (FileStream fs = new FileStream("Products.json", FileMode.OpenOrCreate))
            {
                Product[] products = new Product[5];
                products[0] = new Product(Convert.ToString(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                products[1] = new Product(Convert.ToString(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                products[2] = new Product(Convert.ToString(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                products[3] = new Product(Convert.ToString(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                products[4] = new Product(Convert.ToString(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                await JsonSerializer.SerializeAsync<Product[]>(fs, products);
                Console.WriteLine("Файл создан!");
            }
        }
    }
}
