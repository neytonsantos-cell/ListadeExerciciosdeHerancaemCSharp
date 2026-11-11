using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class Contrato : IImprimivel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo contrato...");
        }
    }
}