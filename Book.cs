using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Book
    {
        public Book(int bookId, string title, string author, decimal rentalPrice)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
        }

        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal RentalPrice { get; set; }


        public override string ToString()
        {
            return $"bookId: {BookId}, title: {Title}, author: {Author}, rentalPrice: {RentalPrice}";
        }

        public virtual string DisplayBookInfo()
        {
            return $"bookId: {BookId}, title: {Title}, author: {Author}, rentalPrice: {RentalPrice}";
        }


    }
}
