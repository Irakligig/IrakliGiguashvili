using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaldelegates
{
    public enum Genre
    {
        Horror , FanFic , Psychological , Historical
    }
    internal class BookClass
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public DateTime? PublicationDate { get; set; }  
        public Genre? Genre { get; set; }
        public int NumberOfPages { get; set; }
        public bool IsAvailable { get; set; }
        public int? Price { get; set; }

        public BookClass(string title,string author,string isbn,string publisher,DateTime? publicationDate,Genre? genre,int numberOfPages,bool isAvailable,int? price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Publisher = publisher;
            PublicationDate = publicationDate;
            Genre = genre;
            NumberOfPages = numberOfPages;
            IsAvailable = isAvailable;
            Price = price;
        }

        public bool TitleValidator(BookClass book)
        {
            string test = book.Title;
            return test.All(char.IsLetter) && test.Length > 1 && test.Length < 255; // all - if all charachters satisfy a predicate
                                            // char.IsLetter - if a character is letter or not
        }

        public bool AuthorValidator(BookClass book)
        {
            string test = book.Author;
            return test.All(char.IsLetter) && test.Length > 3 && test.Length < 255;
        }

        public bool ISBNValidator(BookClass book)
        {
            var test = book.ISBN;
            return test.All(char.IsDigit) && test.Length == 13; 
        }

        public bool PublisherValidator(BookClass book)
        {
            var test = book.Publisher;
            return test is not null && test.Length > 2 && test.Length < 64;
        }

        public bool PublicationDateValidator(BookClass book)
        {
            var test = book.PublicationDate;
            return test < DateTime.Now;
        }

        public bool GenreValidator(BookClass book)
        {
            var test = book.Genre;
            return test is not null;
        }

        public bool NumberOfPagesValidator(BookClass book)
        {
            var test = book.NumberOfPages;
            return test > 0;

        }

        public bool IsAvailableValidator(BookClass book)
        {
            var test = book.IsAvailable;
            return test;
        }

        public bool PriceValidator(BookClass book)
        {
            var test = book.Price;
            return test > 0;
        }


    }
}
