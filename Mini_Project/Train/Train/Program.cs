using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Train
{
    class Program
    {
        public  static SqlConnection conn = null;

        public static SqlCommand comm = null;
        public static IDataReader dr;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Railway Reservation..");
            Console.WriteLine("------------------------------");
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");

           // Console.WriteLine("Connected Successfully:");

            conn.Open();

            while (true)
            {
                Console.WriteLine("You have to register for Admin & User...");
                Console.WriteLine("1.Register,2.Login,3.Exit");
                Console.Write("Enter your choice 1/2/3 : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }
            }
        }

        static void Register()
        {
            try
            {
                conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");

                //Console.WriteLine("Connected successfully:");

                conn.Open();

                Console.Write("Enter Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                Console.Write("Enter Role (Admin/User) : ");
                string role = Console.ReadLine();

                comm = new SqlCommand("sp_Register", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Username", username);
                comm.Parameters.AddWithValue("@Password", password);
                comm.Parameters.AddWithValue("@Role", role);

                comm.ExecuteNonQuery();
                Console.WriteLine("Registration Successfull");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        static void Login()
        {
            conn = new SqlConnection("Data source = ICS-LT-D244D6BJ\\SQLEXPRESS; database = Handson; trusted_connection = true;");
            try
            {
                conn.Open();
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                comm = new SqlCommand("sp_Login", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Username", username);
                comm.Parameters.AddWithValue("@Password", password);

                dr = comm.ExecuteReader();

                if (dr.Read())
                {
                    string role = dr["Role"].ToString();
                    int userId = Convert.ToInt32(dr["Userid"]);

                    Console.WriteLine($"Login Successfull Role: {role}");

                    if (role.Equals("Admin"))
                        AdminMenu();
                    else if (role.Equals("User"))
                        UserMenu(userId);
                }
                else
                {
                    Console.WriteLine("Invalid credentials..");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            finally
            {
                if (dr != null) dr.Close();
                conn.Close();
            }
        }
         static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("------Admin Menu------");
                Console.WriteLine("1.Add Train");
                Console.WriteLine("2.Modify Train");
                Console.WriteLine("3.Delete Train");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter Your Choice : ");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AdminDetails.AddTrain();
                        break;
                    case 2:
                        AdminDetails.ModifyTrain();
                        break;
                    case 3:
                        AdminDetails.DeleteTrain();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Admin Menu");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        static void UserMenu(int userId)
        {
            while (true)
            {
                Console.WriteLine("------User Menu------");
                Console.WriteLine("1.Show All Trains");
                Console.WriteLine("2.Book Ticket");
                Console.WriteLine("3.Cancel Ticket");
                Console.WriteLine("4.View Bookings");
                Console.WriteLine("5.Exit...");
                Console.Write("Enter Your Choice : ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UserDetails.ShowTrains();
                        break;
                    case 2:
                        UserDetails.BookTicket(userId);
                        break;
                    case 3:
                        UserDetails.CancelTicket(userId);
                        break;
                    case 4:
                        UserDetails.ShowBookings(userId);
                        break;
                    case 5:
                        Console.WriteLine("Exiting User Menu");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }
            }
        }
    }
}
