using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class ProdutoDigital
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }

        protected ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}, Preço: {Preco:C2}");
        }
    }
}