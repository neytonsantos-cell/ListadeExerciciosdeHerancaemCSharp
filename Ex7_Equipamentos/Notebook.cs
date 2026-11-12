using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class Notebook : Equipamento
    {
        public int MemoriaRAM { get; set; }
        public Notebook(string? modelo, string? numeroSerie, int memoriaRAM) : base(modelo, numeroSerie)
        {
            MemoriaRAM = memoriaRAM;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Memória RAM: {MemoriaRAM}GB");
        }
    }
}