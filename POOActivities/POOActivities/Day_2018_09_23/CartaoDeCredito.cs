using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_23
{
    class CartaoDeCredito
    {
        private int numero;
        private string dataValidade;
        private Cliente cliente;
        private Fatura[] faturas;

        private static int codigoAtual = 0;

        public int Numero { get => numero; }
        public string DataValidade { get => dataValidade; }
        internal Fatura[] Faturas { get => faturas; }
        internal Cliente Cliente { get => cliente; }

        public CartaoDeCredito(Cliente cliente, string dataValidade){
            this.cliente = cliente;
            this.dataValidade = dataValidade; 
            this.faturas = new Fatura[90];
            this.numero = codigoAtual;
            codigoAtual++;
        }
    }
}
