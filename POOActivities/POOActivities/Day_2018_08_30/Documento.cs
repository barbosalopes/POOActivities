using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_08_30
{
    class Documento
    {
        private static double PrcDocColorido { get; }

        private static double PrcDocPreto { get; }

        private int QntPaginas;

        private char Tipo;

        public Documento(int qntPaginas, char tipo){
            if(qntPaginas < 0){
                throw new Exception("Invalid amount of pages.");
            }

            if()
            QntPaginas = qntPaginas;
            Tipo = tipo;
        }
    }
}
