using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaldelegates
{
    internal class Bookdto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public bool IsAvailable { get; set; }
        public int Price { get; set; }

        public Bookdto(string title , string Author , Genre genre , bool isavailable , int price)
        {
            Title = title;
            Author = Author;
            Genre = genre;
            IsAvailable = isavailable;
            Price = price;
        }
    }
}
