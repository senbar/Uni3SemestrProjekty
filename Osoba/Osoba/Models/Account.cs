using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Models
{
    class Account
    {
        public const string Owner = "Jan Kowalski";

        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value <0)
                    throw new ArithmeticException("saldo nie moze byc ujemne");
                else
                    _saldo = value;
            }
        }
        public const int Pin = 1234;

        public Account()
        {
            _saldo = 10000;
        }
    }
}
