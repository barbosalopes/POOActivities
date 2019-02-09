using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_23
{
    class Agencia
    {
        private int numero;

        private static int codigoAtual = 0;

        public int Numero { get => numero; }

        public Agencia(){
            numero = codigoAtual;
            codigoAtual++;
        }

    }
}
