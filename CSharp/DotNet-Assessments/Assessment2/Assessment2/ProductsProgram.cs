using System;

namespace Assessment2
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;

        public Product(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }
    }

    class ProductsProgram
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");

                Console.Write("Product ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Product(productId, productName, price);
            }

            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = 0; j < products.Length - i - 1; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Products Based on Price:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product ID: {products[i].ProductId}, Name: {products[i].ProductName}, Price: {products[i].Price:C}");
            }
            Console.Read();
        }
    }
}
