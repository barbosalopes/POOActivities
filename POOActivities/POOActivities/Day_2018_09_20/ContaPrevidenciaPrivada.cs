using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_20
{
    class ContaPrevidenciaPrivada : Conta
    {
        // Como nao foi dito coloquei com 2%
        static double tarifaBase;
        static ContaPrevidenciaPrivada()
        {
            tarifaBase = 0.02;
        }
        public ContaPrevidenciaPrivada(Cliente cliente, int numero) : base(cliente, numero)
        {
        }

        public override double saque(double valor)
        {
            if(!(this.Saldo == 0))
            {
                this.Saldo -= this.Saldo * tarifaBase;
            } else
            {
                return -1;
            }
            return base.saque(valor);
        }

        public override void deposita(double valor)
        {
            if (valor > 50000)
                valor -= valor * 0.01;
            else
                valor -= valor * 0.02;
            base.deposita(valor);
        }

    }
}
