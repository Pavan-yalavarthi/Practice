using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
   public class Books
    {
         public string BookName;
         public string AuthorName;

        public Books (string bookName ,string authorName)
        {
            this. BookName = bookName;
            this.AuthorName = authorName;
        }
       public void Display()
        {
            Console.WriteLine("BookName is : " + BookName);
            Console.WriteLine("AuthorName is : " + AuthorName);
        }
    }
   public class BookShelf
    {
         Books[] names = new Books[5];
        public Books this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
    }
    class BookProgram
    {
        static void Main(string[] args)
        {
            BookShelf bs = new BookShelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter The Deatils of Books");
                Console.Write($"Enter Book {i + 1} Name: ");
                Console.WriteLine();
                string bookName = Console.ReadLine();
                Console.Write($"Enter Book {i + 1} AuthorName: ");
                Console.WriteLine();
                string authorName = Console.ReadLine();
                bs[i] = new Books(bookName, authorName);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Book {i + 1} Details are");
                bs[i].Display();
            }
            Console.ReadLine();
        }

    }
}


