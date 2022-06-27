using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Accounts : IPaynator
    {
        public double Balance { get; set; }
        public int Id { get; set; }

        public void Pay ( double price)
        {
            Console.WriteLine($"account ID: {this.Id}\nBalance: {this.Balance}");
            this.Balance = this.Balance - price;
            Console.WriteLine($"new Balance: {this.Balance}");

        }

    }
}
