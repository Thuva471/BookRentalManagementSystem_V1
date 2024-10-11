using BookRentalManagementSystem_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            startwith();
        }


        public static void startwith()
        {
           var manager= new BookManager();
            int option;


            do
            {
                Console.WriteLine("Book Rental Management System:");
                Console.WriteLine("");

                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Update a Book");
                Console.WriteLine("4. Delete a Book");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");


                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Book Author: ");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter Book rental price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        int id = manager.books.Count + 1;
                        var newbook = new Book(id, title, author, price);
                        manager.CreateBook(newbook);
                     break;
                     
                    case 2:

                        Console.Clear();
                        manager.ReadBooks();

                     break;
                        
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter the Book ID to update: ");
                        int newid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new Title:  ");
                        string newtitle = Console.ReadLine();
                        Console.WriteLine("Enter new Author: : ");
                        string newauthor = Console.ReadLine();
                        Console.WriteLine("Enter new rental Price: ");
                        decimal newprice = decimal.Parse(Console.ReadLine());

                        manager.UpdateBook(newid, newtitle, newauthor, newprice);

                     break;

                     case 4:
                        
                        Console.Clear();
                        Console.WriteLine("Enter the Book ID to delete:");
                        int deleteid = int.Parse(Console.ReadLine());

                        manager.DeleteBook(deleteid);

                      break;

                      case 5:
                        Console.Clear();
                        Console.WriteLine("Exting ...");

                       break;

                      default:

                        Console.WriteLine("Invaild option please try agin ...");

                       break;


                }
            } while (option != 5);
           
        }







    }
}
