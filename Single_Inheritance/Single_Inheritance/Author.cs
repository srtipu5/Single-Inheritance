using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    public class Author 
    {
        public  string AuthorName { get; set; }
        public string AuthorNationality { get; set; }
        public string AuthorDetails()
        {
            string details = "Author Name : " + AuthorName + "\n"+
                "Author Nationality : " + AuthorNationality + "\n";
            return details;
        }

    }
}
