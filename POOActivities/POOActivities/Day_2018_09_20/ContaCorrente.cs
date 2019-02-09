using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_20
{
    class ContaCorrente : Conta
    {
        static double tarifaBase;
        protected Cliente segundoTitular;
        protected CartaoDeCredito cartaoDeCredito;

        static ContaCorrente()
        {
            tarifaBase = 0.038;
        }
        public ContaCorrente(Cliente cliente, int numero, Cliente segundoTitular) : base(cliente, numero) {
            this.segundoTitular = segundoTitular;
            cartaoDeCredito = new CartaoDeCredito();

        }
        public override double saque(double valor)
        {
            double valorRetorno = valor;
            if (this.Saldo >= (valor + (valor * tarifaBase)))
                this.Saldo -= (valor + (valor * tarifaBase));
            else
                return -1;
            return valorRetorno;
        }
        public override double transfere(double valor, Conta destino)
        {
            double valorRetorno = valor;
            if (this.Saldo >= (valor + (valor * tarifaBase)))
            {
                this.Saldo -= (valor + (valor * tarifaBase));
                destino.deposita(valor);
            }
            else
                return -1;
            return valorRetorno;
        }
    }
}
