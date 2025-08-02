using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class EBook : Book
    {
        public double FileSize { get; set; }

        public EBook(string _title, string _author, string _isbn, double _fileSize): base(_title, _author, _isbn)
        {
            FileSize = _fileSize;
        }

        public override string ToString()
        {
            base.ToString();
            return $"File Size: {FileSize}";
        }
    }
}
