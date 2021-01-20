using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }

        

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            _titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositioInicial): this(numero, titular)
        {
            Deposito(depositioInicial);

        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }
        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia - 5.0;
        }

        public override string ToString()
        {
            return "Conta: " 
                + Numero 
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
