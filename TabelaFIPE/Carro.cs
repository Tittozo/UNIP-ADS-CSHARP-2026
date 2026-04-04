using System;
using System.Collections.Generic;
using System.Text;

namespace Fipe
{
    internal class Carro : Veículo
    {
        public int NumeroPortas { get; set; }

        public Carro(string marca, string modelo, double precoFIPE, int numeroPortas) : base(marca, modelo, precoFIPE)
        {
            this.NumeroPortas = numeroPortas;
        }

        public override double CalcularValorVenda()
        {
            double dezPer = this.PrecoFIPE * 10 / 100;
            double meioPer = this.PrecoFIPE * (0.5 / 100 * this.NumeroPortas);
            return this.PrecoFIPE + dezPer + meioPer;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"O número de portas é {NumeroPortas}");
        }
    }
}
