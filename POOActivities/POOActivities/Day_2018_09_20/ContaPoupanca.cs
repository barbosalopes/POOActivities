using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_20
{
    class ContaPoupanca : Conta
    {
        static double tarifaBase;
        static ContaPoupanca()
        {
            tarifaBase = 0.019;
        }

        public ContaPoupanca(Cliente cliente, int numero) : base(cliente, numero) {}

        public override double saque(double valor)
        {
            double valorRetorno = valor;
            if (valor > 10000)
            {
                if (this.Saldo >= (valor + (valor * tarifaBase)))
                    this.Saldo -= (valor + (valor * tarifaBase));
                else
                    return -1;
            }
            else
            {
                if (this.Saldo >= valor)
                    this.Saldo -= valor;
                else
                    return -1;
            }

            return valorRetorno;
        }
    }
}
