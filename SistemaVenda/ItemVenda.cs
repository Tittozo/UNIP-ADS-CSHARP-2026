using System;
using System.Collections.Generic;
using System.Text;

namespace SistemadeVenda.Models
{
    internal class NotaFiscal
    {
        public double Subtotal{ get; set; }

        public double Imposto{ get; set; }

        public double ValorTotal { get; set; }

        public NotaFiscal(double subTotal, double imposto, double valorTotal)
        {
            Subtotal = subTotal;
            Imposto = imposto;
            ValorTotal = valorTotal;
        }
    }
}
