using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace practical_1_4_
{
    public enum Genre 
    {
        Fiction,
        NonFiction,
        Mystery,
        Thriller,
        Fantasy,
        ScienceFiction,
        Romance,
        HistoricalFiction,
        Biography,
        Autobiography,
        SelfHelp,
        Horror,
    }

    internal class Book : IComparable<Book> 
    {
        public string FullName { get; set; }
        public string BookTitle { get; set; }
        public int ReleaseYear { get; set; }
        public int ISBN { get; set; }
        public Genre genre { get; set; }


        public Book(string fullname , string booktitle , int releaseyear)
        {
            FullName = fullname;
            BookTitle = booktitle;
            ReleaseYear = releaseyear;
        }

        public int CompareTo(Book? other)
        {
            if (other == null) return 1;
            return ReleaseYear.CompareTo(other.ReleaseYear);
        } // for natural ordering
        public override string ToString()
        {
            return $"{FullName} , {BookTitle} , {ReleaseYear} , {ISBN} , {genre}";
        }

        
    }
}
