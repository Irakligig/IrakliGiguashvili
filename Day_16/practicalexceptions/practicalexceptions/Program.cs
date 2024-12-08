namespace practicalexceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditIban creditiban = new CreditIban("GE09876543210987654321", "irakli giguashvili", 500m, 1000m);
            DebitIban debitiban = new DebitIban("GE12345678901234567890", "irakli giguashvili", 1000m);
            User user = new User("irakli giguashvili" , 551141 , creditiban , debitiban);

            try
            {
                user.CreditAccount.withdraw(2000m);
                user.DebitAccount.Deposit(-200m);
                user.CreditAccount.deposit(500m);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"first error : {ExceptionReader.GetLastInnerExMessage(ex)}");
                Console.WriteLine($"all messages : {ExceptionReader.GetAllInnerExMessageTogether(ex)}");
            }
            finally
            {
                Console.WriteLine("simulation finished");
            }
        }
    }
}
