using System;
using System.Collections.Generic;
using System.Text;

namespace TypePatternV2
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, int tamanhoEquipe) : base(nome, idade)
        {
            this.TamanhoEquipe = tamanhoEquipe;
        }

        public int TamanhoEquipe { get; set; }
    }
}
