using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cachorro
    {
        private int idade;
        private string cor, nome, raca;

        public Cachorro()
        {
            idade = 0;
            cor = null;
            raca = null;
        }

        public Cachorro(int idade, string cor, string nome, string raca)
        {
            this.idade = idade;
            this.cor = cor;
            this.nome = nome;
            this.raca = raca;
        }

        public void latir()
        {
            Console.WriteLine(this.nome + " Latiu");
        }
    }
}
