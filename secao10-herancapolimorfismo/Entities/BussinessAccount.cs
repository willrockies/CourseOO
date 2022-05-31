using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao10_herancapolimorfismo.Entities
{
    internal class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinessAccount()
        {

        }


        public BussinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            Balance += amount - 10.0;
        }
    }
}
