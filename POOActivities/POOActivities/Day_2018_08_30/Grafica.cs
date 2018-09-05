using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOActivities
{
    public class Grafica
    {
        private static double totFatColorido;

        private static double totFatPreto;

        private Impressora impressora;

        /// <returns>double</returns>
        public double FaturaImpressao(Documento documento, char tipoImpressao){
            if (tipoImpressao == Impressora.TipoPreta) {
                return documento.GetQntPaginas() * Impressora.GetPrcDocPreto();
            } else if (tipoImpressao == Impressora.TipoColorida){ 
                return documento.GetQntPaginas() * Impressora.GetPrcDocColorido();
            }
            throw new Exception("Tipo de impressao nao coberto pela impressora");
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