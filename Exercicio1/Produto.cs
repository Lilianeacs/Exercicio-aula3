using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Valor * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            if (quantidade >= Quantidade)
                Quantidade = 0;
            else
                Quantidade -= quantidade;
        }

        public void MostrarProduto()
        {
            Console.Clear();
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Valor: {Valor:C}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Valor Total em Estoque: {ValorTotalEmEstoque():C}");
            Console.ReadKey();
        }
    }
}
