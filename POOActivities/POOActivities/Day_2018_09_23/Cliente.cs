using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_23
{
    class Cliente
    {
        private string nome;
        private int codigo;

        private static int codigoAtual = 0;

        public int Codigo { get => codigo; }
        public string Nome { get => nome; }

        public Cliente(string nome, int codigo){
            this.nome = nome;
            this.codigo = codigo;
            codigoAtual++;
        }
    }
}
