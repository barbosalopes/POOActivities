using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOActivities
{
    public class Impressora
    {
        private double QntTintaPreta
        {
            get => default(int);
            set
            {
            }
        }

        private double QntTintaColorida
        {
            get => default(int);
            set
            {
            }
        }

        /// <value>'p'</value>
        public static char TipoPreta
        {
            get => default(int);
            set
            {
            }
        }

        /// <value>'c'</value>
        public static char TipoColorida
        {
            get => default(int);
            set
            {
            }
        }

        public bool ImprimeDocumento()
        {
            throw new System.NotImplementedException();
        }

        private bool ImprimePagina()
        {
            throw new System.NotImplementedException();
        }

        private void ConsomeTinta()
        {
            throw new System.NotImplementedException();
        }

        public void SubstituiTanque()
        {
            throw new System.NotImplementedException();
        }
    }
}