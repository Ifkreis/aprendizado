using System;
using System.Collections.Generic;
using System.Text;
using primeiro;
using segundo;
using classes;
using inter;
using Enum;
namespace classe
{
    class program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Mikael;
            var pessoa3 = (Pessoas)4;

            pessoa person = new pessoa();
            person.Nome = "Mikael";
            person.idade = 21;
            person.Estado = "BA";

            var person2 = new pessoa();

            person2.Nome = "Ray";
            person2.idade = 19;
            person2.Estado = "BA";

            Animal animal = new Animal();

            animal.Nome = "aika";
            animal.Idade = 3;
            animal.Especie = "cachorro";
            animal.nomeDono = "familia";

            Console.WriteLine(Pessoas.Mikael);
            Console.WriteLine(person2.Nome);
            Console.WriteLine(animal.Nome);
        }
    }
}