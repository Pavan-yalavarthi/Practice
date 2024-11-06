using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Sales
    {
        public int salesNo;
        public int productNo;
        public int price;
        public DateTime dateOfSale;
        public int qty;
        public int totalAmount;


        public Sales(int salesNo, int productNo, int price, DateTime dateOfSale, int qty, int totalAmount)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.dateOfSale = dateOfSale;
            this.qty = qty;
            this.totalAmount = totalAmount;
        }

        public static void sales(int qty, int price)
        {
            int totalAmount = qty * price;
        }
        public static void showData(Sales saleDetails)
        {
            Console.WriteLine("SalesNo is {0}", saleDetails.salesNo);
            Console.WriteLine("ProductNo is {0}", saleDetails.productNo);
            Console.WriteLine("price is {0}", saleDetails.price);
            Console.WriteLine("DateOfSale is {0}", saleDetails.dateOfSale);
            Console.WriteLine("Quantity is {0} ", saleDetails.qty);
            Console.WriteLine("TotalAmount is {0}", saleDetails.totalAmount);
        }

        public static void Main()
        {
            Console.WriteLine("Enter salesno: ");
            int salesNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter productNo: ");
            int productNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DateOfSale: ");
            DateTime dateOfSale = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter TotalAmount: ");
            int totalAmount = Convert.ToInt32(Console.ReadLine());

            Sales saleDetails = new Sales(salesNo, productNo, price, dateOfSale, quantity, totalAmount);
            Sales.showData(saleDetails);
            Console.Read();
        }
    }
}

