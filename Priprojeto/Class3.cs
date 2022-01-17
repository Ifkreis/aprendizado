using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter
{
    interface IAnimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Idade(int idade);
        void Especie(string especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }

        public string nomeDono { get; set; }

        public int Idade { get; set; }

        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Dono(string nomeDono)
        {
            this.nomeDono = nomeDono;
        }
        void IAnimal.Idade(int idade)
        {
            this.Idade = idade;
        }
        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }

    }
}