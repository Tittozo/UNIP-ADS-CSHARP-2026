using System;
using System.Collections.Generic;
using System.Text;

namespace SistemadeVenda.Models
{
    internal class Venda
    {
        public DateTime Data { get; set; }
        public List<ItemVenda> Itens { get; set; }

        public NotaFiscal? NotaFiscal { get; set; }

        public Venda(DateTime data)
        {
            this.Data = data;
            Itens = new List<ItemVenda>();
        }

        public void AdicionarItem (ItemVenda item)
        {
            Itens.Add(item);
        }
    }
}
