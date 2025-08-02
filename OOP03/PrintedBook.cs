using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(string _title, string _author, string _isbn, int _pageCount)
            : base(_title, _author, _isbn)
        {
            PageCount = _pageCount;
        }

        public override string ToString()
        {
            base.ToString();
            return $"Page Count: {PageCount}";
        }
    }
}
