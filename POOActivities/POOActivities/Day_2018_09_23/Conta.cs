using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_23
{
    class Conta
    {
        private double saldo;
        private Agencia agencia;

        public double Saldo { get => saldo; }
        internal Agencia Agencia { get => agencia; }

        public Conta(Agencia ag){
            agencia = ag;
            saldo = 0;
        }

        public void deposita(double val){
            if (val < 0)
                throw new ArgumentOutOfRangeException("O valor nao pode ser menor que 0!");
            saldo += val;
        }

        public void saca(double val){
            if (val < 0)
                throw new ArgumentOutOfRangeException("O valor nao pode ser menor que 0!");
            else if(saldo < val) {
                throw new ArgumentOutOfRangeException("O valor nao pode ser maior que o saldo!");
            }
            saldo -= val;
        }

        public string imprimeExtrato(){
            return ToString();
        }

        public override string ToString(){
            return "Agencia: " + agencia.Numero + " | Saldo: " + saldo;
        }

        public void tranfere(Conta destino, double valor){
            saca(valor);
            destino.deposita(valor);
        }
    }
}
