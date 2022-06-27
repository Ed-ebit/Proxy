namespace Proxy
{
    class Program
    {
        public static void Main()
        {
            Accounts accountA = new Accounts();
            Accounts accountB = new Accounts();
            Random rnd = new Random();
            accountA.Balance = rnd.NextDouble() * 1000 + rnd.NextDouble() * 10;
            accountB.Balance = rnd.NextDouble() * 1000 + rnd.NextDouble() * 10;
            PaymentCard KreditKarte = new PaymentCard(accountA, accountB);

            // set AccountBalances

            Console.WriteLine("Bitte Produktpreis eingeben!");
            string input = Console.ReadLine();
            double price = Convert.ToDouble(input);

            Console.WriteLine("wird bezahlt mit Kreditkarte...");
            Thread.Sleep(1000);

            KreditKarte.Pay(price);


        }
    }
}