using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_1_4_
{
    class CompareByTitle : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x == null || y == null) return 0;
            return x.BookTitle.CompareTo(y.BookTitle);  
        }
    }
}
