using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductStorage myList = new ProductStorage();
            
            myList.AddProduct(new Product("Zanahoria", "vegetal", "comestibles", 10.5, 50));
            myList.AddProduct(new Product("Tomate", "vegetal", "comestibles", 9.5, 80));
            myList.AddProduct(new Product("Mango", "fruta", "comestibles", 8, 500));
            myList.AddProduct(new Product("Pera", "fruta", "comestibles", 15, 450));
            myList.AddProduct(new Product("Frijol", "granos", "comestibles", 12.3, 105));
            myList.AddProduct(new Product("Mani", "granos", "comestibles", 16.3, 85));

            myList.AddProduct(new Product("Gomas", "14x15", "repuestos", 150, 20));
            myList.AddProduct(new Product("Gomas", "15x18", "repuestos", 152, 40));
            myList.AddProduct(new Product("Motor", "kia", "repuestos", 105, 30));
            myList.AddProduct(new Product("Correa", "kia", "repuestos", 155, 15));

            var filter = myList.Products.Where(x => x.Category.ToUpper() == "COMESTIBLES").ToList();

            Console.WriteLine("Comestibles");
            foreach (var item in filter)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Category + " " + item.Price + " " + item.Quantity);
                Console.WriteLine("--");
            }

            filter = myList.Products.Where(x => x.Category.ToUpper() == "REPUESTOS").ToList();

            Console.WriteLine("--------------");
            Console.WriteLine("Repuestos");
            foreach(var item in filter)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Category + " " + item.Price + " " + item.Quantity);
                Console.WriteLine("--");
            }

            filter = myList.Products.Where(x => x.Price < 100).ToList();

            Console.WriteLine("--------------");
            Console.WriteLine("Precio menor que 100");
            foreach (var item in filter)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Category + " " + item.Price + " " + item.Quantity);
                Console.WriteLine("--");
            }

            filter = myList.Products.Where(x => x.Quantity > 85).ToList();

            Console.WriteLine("--------------");
            Console.WriteLine("Menor cantidad que 85");
            foreach (var item in filter)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Category + " " + item.Price + " " + item.Quantity);
                Console.WriteLine("--");
            }

            filter = myList.Products.Where(x => x.Category.ToUpper() == "COMESTIBLES" && x.Price > 9).ToList();

            Console.WriteLine("--------------");
            Console.WriteLine("Comestible con precio mayor que 9");
            foreach(var item in filter)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Category + " " + item.Price + " " + item.Quantity);
                Console.WriteLine("--");
            }

            filter = myList.Products.OrderBy(x => x.Price).ToList();
            
            Console.WriteLine("--------------");
            Console.WriteLine("Precio menor a mayor");
            foreach( var item in filter)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Category + " " + item.Price + " " + item.Quantity);
                Console.WriteLine("--");
            }

            filter = myList.Products.OrderByDescending(x => x.Price).ToList();

            Console.WriteLine("--------------");
            Console.WriteLine("Precio menor a mayor");
            foreach (var item in filter)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Category + " " + item.Price + " " + item.Quantity);
                Console.WriteLine("--");
            }

            filter = myList.Products.OrderByDescending(x => x.Price).ToList();

            Console.WriteLine("--------------");
            Console.WriteLine("Precio mayor a menor");
            foreach (var item in filter)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Category + " " + item.Price + " " + item.Quantity);
                Console.WriteLine("--");
            }

        }
    }

    class Product
    {
        private string name;
        private string description;
        private string category;
        private double price;
        private int quantity;

        public Product(string name, string description, string category, double price, int quantity)
        {
            this.name = name;
            this.description = description;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
    class ProductStorage
    {
        private List<Product> products;

        public ProductStorage()
        {
            products = new List<Product>();
        }

        public List<Product> Products
        {
            get { return products; }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);

        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
    }
}
