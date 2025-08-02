using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string _title, string _author, string _isbn)
        {
            Title = _title;
            Author = _author;
            ISBN = _isbn;
        }

        public override string ToString()
        {
            return $"Title : {Title}\n Author : {Author} \n ISBN : {ISBN}";
        }
    }

}
