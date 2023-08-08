namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto mercadoria = new Produto();
            mercadoria.Nome = "Mouse";
            mercadoria.Valor = 250.89;
            mercadoria.Quantidade = 5;

            mercadoria.MostrarProduto();
            mercadoria.AdicionarProduto(3);
            mercadoria.MostrarProduto();
            mercadoria.RemoverProdutos(2);
            mercadoria.MostrarProduto();
        }
    }
}