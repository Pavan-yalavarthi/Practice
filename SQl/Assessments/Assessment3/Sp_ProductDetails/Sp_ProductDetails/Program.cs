using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sp_ProductDetails
{
    class Program
    {
        public static SqlConnection conn = null;
        public static SqlCommand comm = null;
        public static IDataReader reader = null;
        void Products()
        {
            //Connect to database.
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; Database = Assignment1; trusted_connection = true;");
            Console.WriteLine("Successfully connected:");
  
            conn.Open();
    
            comm = new SqlCommand("sp_productdetails", conn);
            comm.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter the product id:");
            int ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product_name:");
            String ProductName = Console.ReadLine();
            Console.WriteLine("Enter the Product price:");
            float Price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the discounted Price:");
            float DiscountedPrice = Convert.ToSingle(Console.ReadLine());
            DiscountedPrice = Price - 0.10f;

            comm.Parameters.Add(new SqlParameter("@productId", SqlDbType.Int)).Value = ProductId;
            comm.Parameters.Add(new SqlParameter("@productName", SqlDbType.VarChar, 40)).Value = ProductName;
            comm.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float)).Value = Price;
            comm.Parameters.Add(new SqlParameter("@DiscountedPrice", SqlDbType.Float)).Value = DiscountedPrice;


            int result = comm.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Success:");
            }
            else
            {
                Console.WriteLine("Fail:");
            }
            conn.Close();

        }
        void selectQuery()
        {
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; Database = Assignment1; trusted_connection = true;");
            Console.WriteLine("Successfully connected:");
            
            conn.Open();
           
            comm = new SqlCommand("sp_productdetails", conn);
            comm.CommandType = CommandType.StoredProcedure;
            Console.WriteLine("Enter the product id:");
            int ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product_name:");
            String ProductName = Console.ReadLine();
            Console.WriteLine("Enter the Product price:");
            float Price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the discounted Price:");
            float DiscountedPrice = Convert.ToSingle(Console.ReadLine());
            
            comm.Parameters.Add(new SqlParameter("@productId", SqlDbType.Int)).Value = ProductId;
            comm.Parameters.Add(new SqlParameter("@productName", SqlDbType.VarChar, 40)).Value = ProductName;
            comm.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float)).Value = Price;
            comm.Parameters.Add(new SqlParameter("@DiscountedPrice", SqlDbType.Float)).Value = DiscountedPrice;



            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ProductId is:" + reader[0] + "ProductName is:" + reader[1] + "Price:" + reader[2] + "DiscountedPrice:" + reader[3]);
            }
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Products();
            p.selectQuery();
            Console.Read();
        }
    }
}
