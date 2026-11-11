using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class JogoDigital : Jogo
    {
        public double TamanhoGB { get; set; }

        public JogoDigital(string nome, string plataforma, double tamanhoGB) : base(nome, plataforma)
        {
            TamanhoGB = tamanhoGB;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Plataforma: {Plataforma}, Tamanho: {TamanhoGB} GB");
        }
    }

}