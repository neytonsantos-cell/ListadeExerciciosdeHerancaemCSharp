using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }
        protected string? Plataforma; //campo protegido, acessível apenas dentro da classe e suas subclasses

        protected Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }
        public abstract void ExibirInformacoes(); //método abstrato, deve ser implementado nas subclasses
    }
}