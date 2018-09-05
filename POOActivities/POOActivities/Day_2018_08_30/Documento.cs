using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOActivities
{
    public class Documento
    {

        private int QntPaginas;

        private char Tipo;

        public Documento(int qntPaginas, char tipo){
            QntPaginas = qntPaginas;
            Tipo = tipo;
        }

        public int GetQntPaginas(){
            return QntPaginas;
        }

        public char GetPrcDocPreto(){
            return Tipo;
        }
        
    }
}