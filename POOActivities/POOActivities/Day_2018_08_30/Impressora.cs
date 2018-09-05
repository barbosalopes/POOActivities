using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOActivities
{
    public class Impressora
    {
        private static double prcDocColorido = 1.2;

        private static double prcDocPreto = .2;
        private double QntTintaPreta;

        private double QntTintaColorida;

        /// <value>'p'</value>
        public static readonly char TipoPreta = 'p';

        /// <value>'c'</value>
        public static readonly char TipoColorida = 'c';

        public static double GetPrcDocColorido(){
            return prcDocColorido;
        }

        public static double GetPrcDocPreto(){
            return prcDocPreto;
        }

        public bool ImprimeDocumento(Documento doc, char tipoImpressao){
            bool imprimiuCorretamente;
            int paginaAtual = 0;
            do
            {
                imprimiuCorretamente = ImprimePagina(tipoImpressao);
                paginaAtual++;
            } while (imprimiuCorretamente && paginaAtual < doc.GetQntPaginas());
        }

        private bool ImprimePagina(char tipoImpressao){
            if (tipoImpressao == TipoColorida && QntTintaColorida < 0){
                QntTintaColorida = 0;
                return false;
            } else if(QntTintaPreta < 0){
                QntTintaPreta = 0;
                return false;
            } else {
                return true;
            }

        }

        private void ConsomeTinta(char tipoImpressao){
            if (tipoImpressao == TipoColorida){
                QntTintaColorida -= 2.5;
            } else {
                QntTintaPreta--;
            }
        }

        public void SubstituiTanque()
        {
            throw new System.NotImplementedException();
        }
    }
}