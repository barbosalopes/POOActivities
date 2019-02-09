using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActivities.Day_2018_09_20
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public Cliente(string nome, int numero)
        {
            this.Nome = nome;
            this.Numero = numero;
        }

    }
}
