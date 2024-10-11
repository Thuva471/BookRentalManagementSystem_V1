using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class EBook :Book
    {
        public EBook(int bookId, string title, string author, decimal rentalPrice , double filesize , string format) : 
        
        base(bookId, title, author, rentalPrice)
        {
        }

        public double FileSize { get; set; }

        public string Format { get; set; } 

        public  string DisplayDigitalBookInfo()
        {
            return $"{DisplayBookInfo()}, FileSize : {FileSize} , Format : {Format} ";
        }

        public override  string DisplayBookInfo()
        {
            return base.DisplayBookInfo() + $", FileSize : {FileSize}MB , Format : {Format}";
        }
    }
}
