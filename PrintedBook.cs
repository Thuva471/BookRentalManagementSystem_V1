using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class PrintedBook : Book
    {
        public PrintedBook(int bookId, string title, string author, decimal rentalPrice , int isbn , int numberofpage) : 
            
         base(bookId, title, author, rentalPrice)
        {
        }

        public int ISBN { get; set; }

        public  int NumberOfPages { get; set; }


        public string DisplayPrintedBookInfo()
        {
            return $"{DisplayBookInfo()}, ISBN : {ISBN} , Format : {NumberOfPages} ";
        }

        public override string DisplayBookInfo()
        {
            return base.DisplayBookInfo() + $", ISBN : {ISBN} , NumberOfPages : {NumberOfPages}";
        }

    }
}
