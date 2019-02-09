using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_23
{
    class Fatura
    {
        private double total;

        public void adiciona(double valor){
            if (valor < 0)
                throw new ArgumentOutOfRangeException("O valor nao pode ser menor que 0!");
            total += valor;
        }

        public double calculaMulta(){
            return total * 1.02;
        }

        public string ImprimeDados(){
            return "Total: " + total;
        }
    }
}
