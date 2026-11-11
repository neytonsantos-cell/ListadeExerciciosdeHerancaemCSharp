using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class Relatorio : IExportavel, IImprimivel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório...");
        }
        public void Exportar()
        {
            Console.WriteLine("Exportando relatório para  PDF...");
        }
        
    }
}