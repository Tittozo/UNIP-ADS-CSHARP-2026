using System;
using System.Collections.Generic;
using System.Text;

namespace SistemadeVenda.Service
{
    internal class ImpostoBrasilService
    {
        public double CalcularImposto(double valor)
        {
            if (valor <= 100.00)
            {
                return valor * 0.05; 
            }
            else
            {
                return valor * 0.10; 
            }
        }
    }
}
