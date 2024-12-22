using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Train
{
    class AdminDetails
    {
        public static SqlConnection conn = null;

        public static SqlCommand comm = null;

       public static void AddTrain()
        {
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");
            try
            {
                Console.WriteLine("Enter The Train Id : ");
                int trainId = int.Parse(Console.ReadLine());

                Console.Write("Enter Train Name: ");
                string trainname = Console.ReadLine();

                Console.Write("Enter Source: ");
                string source = Console.ReadLine();

                Console.Write("Enter Destination: ");
                string destination = Console.ReadLine();


                Console.Write("Enter total First class Seats: ");
                int firstclass = int.Parse(Console.ReadLine());

                Console.Write("Enter total Second class Seats: ");
                int secondclass = int.Parse(Console.ReadLine());

                Console.Write("Enter total Sleeper class Seats: ");
                int sleeperclass = int.Parse(Console.ReadLine());
                Console.WriteLine($"TrainId: {trainId}, TrainName: {trainname}, Source: {source}, Destination: {destination}, FirstClass: {firstclass}, SecondClass: {secondclass}, SleeperClass: {sleeperclass}");

                conn.Open();
                SqlCommand comm = new SqlCommand("sp_AddTrain", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@TrainId", trainId);
                comm.Parameters.AddWithValue("@TrainName", trainname);
                comm.Parameters.AddWithValue("@Source", source);
                comm.Parameters.AddWithValue("@Destination", destination);
                comm.Parameters.AddWithValue("@FirstClass", firstclass);
                comm.Parameters.AddWithValue("@SecondClass", secondclass);
                comm.Parameters.AddWithValue("@SleeperClass", sleeperclass);
                // comm.Parameters.AddWithValue("@IsActive",IsActive);

                int rowsAffected = comm.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Train added Successfully..");
                }
                else
                {
                    Console.WriteLine("Failed to add train");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error: "+ex.Message);
                
            }
        }


       public static void ModifyTrain()
        {
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");
            Console.Write("Enter Train ID to Modify: ");
            int trainId = int.Parse(Console.ReadLine());

            Console.Write("Enter New Train Name: ");
            string trainName = Console.ReadLine();

            Console.Write("Enter New Source: ");
            string source = Console.ReadLine();

            Console.Write("Enter New Destination: ");
            string destination = Console.ReadLine();

            Console.Write("Enter New Total First Class Seats: ");
            int firstClassSeats = int.Parse(Console.ReadLine());

            Console.Write("Enter New Total Second Class Seats: ");
            int secondClassSeats = int.Parse(Console.ReadLine());

            Console.Write("Enter New Total Sleeper Class Seats: ");
            int sleeperClassSeats = int.Parse(Console.ReadLine());


            conn.Open();
            SqlCommand comm = new SqlCommand("sp_ModifyTrain", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@TrainID", trainId);
            comm.Parameters.AddWithValue("@TrainName", trainName);
            comm.Parameters.AddWithValue("@Source", source);
            comm.Parameters.AddWithValue("@Destination", destination);
            comm.Parameters.AddWithValue("@FirstClass", firstClassSeats);
            comm.Parameters.AddWithValue("@SecondClass", secondClassSeats);
            comm.Parameters.AddWithValue("@SleeperClass", sleeperClassSeats);

            int rowsAffected = comm.ExecuteNonQuery();
            if (rowsAffected > 0)
                Console.WriteLine("Train modified successfully!");
            else
                Console.WriteLine("Train ID not found.");
        }


        // Soft Delete Train
       public static void DeleteTrain()
        {
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");
            Console.Write("Enter Train ID to Delete (Soft Delete): ");
            int trainId = int.Parse(Console.ReadLine());

            conn.Open();
            SqlCommand comm = new SqlCommand("sp_DeleteTrain", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@TrainID", trainId);

            int rowsAffected = comm.ExecuteNonQuery();
            if (rowsAffected > 0)
                Console.WriteLine("Train deleted successfully (soft delete)!");
            else
                Console.WriteLine("Train ID not found.");

        }
    }
}
