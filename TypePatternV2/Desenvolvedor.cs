using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TypePatternV2
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, int idade, string linguagem, int anosExperiencia) : base(nome, idade)
        {
            this.Linguagem = linguagem;
            this.AnosExperiencia = anosExperiencia;
        }

        public string Linguagem { get; set; }
        public int AnosExperiencia { get; set; }
    }
}
