using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public abstract class Equipamento
    {
        public string?  Modelo { get; set; }
        protected string? NumeroSerie;
        protected Equipamento(string? modelo, string? numeroSerie)
        {
            Modelo = modelo;
            NumeroSerie = numeroSerie;
        }
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}, Número de Série: {NumeroSerie}");
        }
    }
}