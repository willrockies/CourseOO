using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao10_herancapolimorfismo.Entities
{
    internal class SavingsAccount : Account
    {
        public Double InterestRate { get; set; }
        public SavingsAccount() { }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /*public override void Withdrawn(double amount)
        {
            Balance -= amount;
        }*/

        public sealed override void Withdrawn(double amount)
        {
            base.Withdrawn(amount);
            Balance -= 2.0;
        }
    }
}
