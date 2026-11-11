using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class JogoFisico : Jogo
    {
        public string? TipoMidia { get; set; }

        public JogoFisico(string nome, string plataforma, string tipoMidia) : base(nome, plataforma)
        {
            TipoMidia = tipoMidia;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Plataforma: {Plataforma}, Tipo de Mídia: {TipoMidia}");
        }
    }
}