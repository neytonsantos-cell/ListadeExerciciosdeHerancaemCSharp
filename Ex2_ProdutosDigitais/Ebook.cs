using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas  { get; set; }

        public Ebook(string nome, decimal preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Quantidade de Páginas: {QuantidadePaginas}");            
        }
    }
}