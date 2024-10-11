using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {
        public List<Book> books = new List<Book>();

        public void CreateBook(Book book)
        {
            ValidateBookRentalPrice(book);
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        public void ReadBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Not Found Book");
            }
            else
            {
                foreach (var book in books)
                {

                    Console.WriteLine(book);

                }

            }
        }


        public void UpdateBook(int bookid, string newtitle ,string newauthor, decimal newprice)
        {
            var book = books.Find(a => a.BookId == bookid);
            if (book != null)
            {
                if(newprice <= 0)
                {
                    Console.WriteLine("Retalprice must postiove value please try agin ..");
                }
                book.Title = newtitle;
                book.Author = newauthor;
                book.RentalPrice = newprice;
            }
            else
            {
                Console.WriteLine("Book Not Fuond .. ");
            }
        }

        public void DeleteBook(int bookid)
        {
            var book = books.Find(b => b.BookId == bookid);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }

        }

        public void ValidateBookRentalPrice(Book book)
        {
           while (book .RentalPrice <= 0)
            {

                Console.WriteLine("Retalprice must postiove value please try agin ..");
                book .RentalPrice = decimal.Parse(Console.ReadLine());
            }
        }


    }
}
