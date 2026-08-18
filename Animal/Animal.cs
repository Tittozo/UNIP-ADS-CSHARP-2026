using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public string Especie { get; set; }

        public Animal(string nome, int idade, double peso, string especie)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Especie = especie;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Se prepara para emitir som");
            Console.WriteLine("Som do animal");
        }

        public virtual void Comer()
        {
            Console.WriteLine("O animal está comendo");
        }
    }
}
