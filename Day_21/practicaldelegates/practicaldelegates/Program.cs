namespace practicaldelegates
{
    internal class Program
    {
        public delegate void LogMessage(string message);
        public delegate decimal MathOperation(decimal x , decimal y);
        public delegate bool Validator(BookClass book);
        static void Main(string[] args)
        {
            //1
            //LogMessage Logdel = ConsolidatedLogging.LoggingOnConsole;
            //Logdel += ConsolidatedLogging.LoggingOnTxt;

            //string message = "input message";
            //Logdel(message);

            //2
            //MathOperation MathDel = Mathoperations.Add;
            //MathDel += Mathoperations.Subs;
            //MathDel += Mathoperations.Mult;
            //MathDel += Mathoperations.Div;

            //foreach (var x in MathDel.GetInvocationList())
            //{
            //    var y = (MathOperation)x;
            //    Console.WriteLine(y(3,4));
            //}

            //3
            BookClass book = new BookClass("dad", "avtori", "1234567891234", "saxeli gvari", new DateTime(1977, 1, 28), Genre.Horror, 447, true, 25);
            Validator ValDel = book.TitleValidator;
            ValDel += book.AuthorValidator;
            ValDel += book.ISBNValidator;
            ValDel += book.PublisherValidator;
            ValDel += book.PublicationDateValidator;
            ValDel += book.GenreValidator;
            ValDel += book.NumberOfPagesValidator;
            ValDel += book.IsAvailableValidator;
            ValDel += book.PriceValidator;

            bool result = true;
            foreach (Delegate del in ValDel.GetInvocationList())
            {
                var x = (Validator)del;
                result &= x(book);
            }
            Console.WriteLine(result);

            Validator ValDelEssential = book.TitleValidator;
            ValDelEssential += book.AuthorValidator;
            ValDelEssential += book.ISBNValidator;

            bool result2 = true;
            foreach (Delegate del in ValDelEssential.GetInvocationList())
            {
                var x = (Validator)del;
                result &= x(book);
            }


            //4
            List<BookClass> books = new List<BookClass>();  
            
        }
    }
}

