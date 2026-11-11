using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class EntregaEconomica : Entrega
    {
        private const double TarifaReduzida = 1.20;

        public EntregaEconomica(double distancia) : base(distancia) { }

        public override double CalcularFrete()
        {
            return Distancia * TarifaReduzida;
        }
    }
}