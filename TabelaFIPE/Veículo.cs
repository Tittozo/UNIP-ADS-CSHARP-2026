using System;
using System.Collections.Generic;
using System.Text;

namespace Fipe
{
    internal abstract class Veículo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double PrecoFIPE { get; set; }

        public Veículo(string marca, string modelo, double precoFIPE)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.PrecoFIPE = precoFIPE;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Marca do Veículo: {Marca}");
            Console.WriteLine($"Modelo do Veículo: {Modelo}");
            Console.WriteLine($"Tabela Fipe do Veículo: {PrecoFIPE:F2}");

        }

        public abstract double CalcularValorVenda();
    }
}
