using System;
using System.Collections.Generic;
using System.Text;

namespace TypePatternV2
{
    internal class Estagiario : Funcionario
    {
        public Estagiario(string nome, int idade, int horasSemanais) : base(nome, idade)
        {
            this.HorasSemanais = horasSemanais;
        }

        public int HorasSemanais { get; set; }
    }
}
