using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace hweh
{
    public class bookclass
    {
        public string title;
        public string author;
        public int pages;

        public bookclass() { 
            

        }

        public bookclass(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

    }
}