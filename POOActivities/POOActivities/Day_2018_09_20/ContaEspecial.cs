using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_20
{
    class ContaEspecial : Conta
    {
        protected CartaoDeCredito cartaoDeCredito;
        public ContaEspecial(Cliente cliente, int numero) : base(cliente, numero) {
            cartaoDeCredito = new CartaoDeCredito();
        }

        public override double saque(double valor)
        {
            this.Saldo -= valor;
            return valor;
        }
    }
}
