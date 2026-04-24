using SistemadeVenda.Models;
using SistemadeVenda.Service;

namespace SistemaVenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Chocolate", 2.5);
            Produto p2 = new Produto("Coca", 3);
            Produto p3 = new Produto("Salgadinho",1.5);

            Venda venda = new Venda(DateTime.Now);

            ItemVenda it1 = new ItemVenda(p1, 2);
            ItemVenda it2 = new ItemVenda(p2, 1);
            ItemVenda it3 = new ItemVenda(p3, 3);

            venda.AdicionarItem(it1);
            venda.AdicionarItem(it2);
            venda.AdicionarItem(it3);

            VendaService vendaService = new VendaService();

            vendaService.ProcessarVenda(venda);

            Console.WriteLine("=== Relatório Venda ====");

            Console.WriteLine(venda.Data);
            foreach (ItemVenda item in venda.Itens)
            {
                Console.Write($"Nome do Produto: {item.Produto.Nome} ");
                Console.Write($"Preço do Produto: {item.Produto.Preco} ");
                Console.Write($"Quantidade: {item.Qtd} ");
                Console.WriteLine($"Subtotal: {item.SubTotal()} \n");
            }



        }
    }
}
