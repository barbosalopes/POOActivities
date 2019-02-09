using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_20
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public Conta(Cliente cliente, int numero)
        {
            this.Titular = cliente;
            this.Numero = numero;
            this.Saldo = 0;
        }

        public virtual void deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual double saque(double valor)
        {
            double valorRetorno = valor;
            if (this.Saldo >= valor)
                this.Saldo -= valor;
            else
                return -1;
            return valorRetorno;
        }
        public virtual double transfere(double valor, Conta destino)
        {
            double valorRetorno = valor;
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                destino.deposita(valor);
            }
            else
                return -1;
            return valorRetorno;

        }
    }
}
