using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    internal class Cachorro: Animal
    {
        public char Sexo { get;  set; }
        
        public Cachorro (string nome, int idade, double peso, string especie, char sexo): base(nome, idade, peso, especie)
        {
            Sexo = sexo;
        }
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("Latino");
        }

        public override void Comer()
        {
            Console.WriteLine("Comendo ração dos racãocionais");
        }
    }
}

