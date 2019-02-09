using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_20
{
    class CartaoDeCredito
    {
        private int numero;
        private DateTime validade;
        private double anuidade;

        protected int Numero { get => numero; set => numero = value; }
        protected DateTime Validade { get => validade; set => validade = value; }
        protected double Anuidade { get => anuidade; set => anuidade = value; }
    }
}
