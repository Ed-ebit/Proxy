namespace Proxy
{
    class Program
    {
        public static void Main()
        {
            Random rnd = new Random();
            List<Accounts> accountList = new List<Accounts>();
            int accountsNumber = rnd.Next(15);
            for (int i = 1; i <= accountsNumber; i++)
            {
                accountList.Add(new Accounts()
                {
                    Id = i,
                    Balance = rnd.NextDouble() * 1000
                });
            }
            PaymentCard KreditKarte = new PaymentCard(accountList);

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