using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class PaymentCard
    {
        Accounts? AccountA { get; } // um beliebig viele Accounts erweitern?
        Accounts? AccountB { get; }

        public PaymentCard(Accounts? accountA, Accounts? accountB)
        {
            this.AccountA = accountA;
            this.AccountB = accountB;
        }

        public void Pay(double price)
        {
            Console.WriteLine("Kontostand Konto A: "+AccountA.Balance + "\n" +
                "Kontostand Konto B: "+AccountB.Balance);
            double percentsAccountA = AccountA.Balance/(AccountA.Balance + AccountB.Balance);
            double percentsAccountB = AccountB.Balance / (AccountA.Balance + AccountB.Balance);
            double paidMoney = percentsAccountA * price + percentsAccountB * price;
            AccountA.Balance = AccountA.Balance - percentsAccountA * price;
            AccountB.Balance = AccountB.Balance - percentsAccountB * price;
            Console.WriteLine("bezahlt: "+paidMoney);
            Console.WriteLine("Kontostand Konto A: " + AccountA.Balance + "\n" +
                "Kontostand Konto B: " + AccountB.Balance);

        }

    }
}
