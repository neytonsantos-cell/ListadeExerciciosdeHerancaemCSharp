using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class EntregaExpressa : Entrega
    {
        private const double TarifaPorKm = 2.50;
        private const double TaxaAdicional = 15.00;

        public EntregaExpressa(double distancia) : base(distancia) {}

        public override double CalcularFrete()
        {
            return Distancia * TarifaPorKm + TaxaAdicional;
        }
        
    }
}