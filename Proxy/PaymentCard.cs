using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class PaymentCard : IPaynator
    {
        readonly List<Accounts> Accounts;

        public PaymentCard(List<Accounts> accounts)
        {
            this.Accounts = accounts;
        }

        public void Pay(double price)
        {
            List<Accounts> thickMoneyAccounts = Accounts
                .FindAll((account) => account.Balance > 0);

            double total = thickMoneyAccounts
                .Aggregate(0d,(current,account)=> current+account.Balance);

            double moneyPaid = 0;
            foreach (Accounts account in thickMoneyAccounts)
            {
                double moneyToPay  = account.Balance / total * price;
                account.Pay(moneyToPay);
                moneyPaid += moneyToPay;
            }

            Console.WriteLine("bezahlt: "+ moneyPaid);

        }

    }
}
