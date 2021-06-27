using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    public class Book:Author
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }
        public string BookDetails()
        {
            string details = "Book Id : " + BookId + "\n"+
                "Book Name : " + BookName + "\n" +
                "Book Type : " + BookType + "\n"+AuthorDetails();
            return details;
        }
    }
}
