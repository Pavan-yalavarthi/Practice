using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Train
{
    class UserDetails
    {
        public static SqlConnection conn = null;

        public static SqlCommand comm = null;

        public static IDataReader reader = null;

        public static void ShowTrains()
        {
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");
            Console.WriteLine("\nAvailable Trains:");

            conn.Open();
            SqlCommand comm = new SqlCommand("sp_ShowTrains", conn);
            comm.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"TrainID: {reader[0]}, Train Name: {reader[1]}, Source: {reader[2]}, Destination: {reader[3]}, First Class: {reader[4]}, Second Class: {reader[5]}, Sleeper Class: {reader[6]}");
            }
        }

        public static void BookTicket(int userId)
        {
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");

            Console.WriteLine("Enter Username :");
            string username = Console.ReadLine();
            Console.Write("Enter Train ID to Book: ");
            int trainId = int.Parse(Console.ReadLine());

            Console.Write("Enter Class (FirstClass/SecondClass/SleeperClass): ");
            string trainClass = Console.ReadLine();

            Console.WriteLine("Enter Number of Seats :");
            int seats = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Booking id");
            //int bookingId = int.Parse(Console.ReadLine());


            conn.Open();
                SqlCommand comm = new SqlCommand("sp_BookTicket", conn);
                comm.CommandType = CommandType.StoredProcedure;
                 comm.Parameters.AddWithValue("@UserId", userId);
                comm.Parameters.AddWithValue("@UserName", username);
                comm.Parameters.AddWithValue("@TrainID", trainId);
                comm.Parameters.AddWithValue("@BookingClass", trainClass);
                comm.Parameters.AddWithValue("@NumberOfSeats", seats);
               // comm.Parameters.AddWithValue("@BookingId", bookingId);

            //int bookingId = Convert.ToInt32(comm.ExecuteScalar());
            comm.ExecuteNonQuery();
                Console.WriteLine("Ticket booked successfully!");
            
        }

        public static void CancelTicket(int userId)
        {
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");
            Console.Write("Enter Booking ID to Cancel: ");
            int bookingId = int.Parse(Console.ReadLine());

            conn.Open();
            SqlCommand comm = new SqlCommand("sp_CancelTicket", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@BookingID", bookingId);
            
            int rowsAffected = comm.ExecuteNonQuery();
            if (rowsAffected > 0)
                Console.WriteLine("Ticket canceled successfully!");
            else
                Console.WriteLine("Invalid Booking ID!");

        }


        public static void ShowBookings(int userId)
        {
           string connectionString = "Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    Console.WriteLine("--------Your Bookings-------------");
                    Console.WriteLine();
                    Console.Write("Enter Booking ID to Show : ");
                    int bookingId = int.Parse(Console.ReadLine());

                    conn.Open();
                    SqlCommand comm = new SqlCommand("sp_ViewBookings", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    //comm.Parameters.AddWithValue("@TrainID", trainId);
                    //comm.Parameters.AddWithValue("@UserID", userId);
                    comm.Parameters.AddWithValue("@BookingID", bookingId);
                    SqlDataReader reader = comm.ExecuteReader();
                    
                        if (reader.Read())
                        {
                            Console.WriteLine($"BookingID: {reader[0]}, TrainID: {reader[1]}, BookingClass: {reader[3]}, NumberOfSeats: {reader[4]}, Booking Date: {reader[5]}");
                            Console.WriteLine("-------Thank You--------");
                        }
                        else
                        {
                            Console.WriteLine("No Bookings Found With bookingId :" + bookingId);
                        }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An Error :{ex.Message}");
                }
                conn.Close();
            }
        }
    }
}
