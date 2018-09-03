using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOActivities
{
    public class Grafica : Impressora
    {
        private static double TotFatColorido
        {
            get => default(int);
            set
            {
            }
        }

        private double TotFatPreto
        {
            get => default(int);
            set
            {
            }
        }

        private Impressora Impressora
        {
            get => default(Impressora);
            set
            {
            }
        }

        /// <returns>double</returns>
        public double FaturaImpressao(Documento documento)
        {
            throw new System.NotImplementedException();
        }

        public void ImprimeDocumento()
        {
            throw new System.NotImplementedException();
        }

        public double CalcTotFaturado()
        {
            throw new System.NotImplementedException();
        }

        public double CalcTotFatPorTipo()
        {
            throw new System.NotImplementedException();
        }
    }
}