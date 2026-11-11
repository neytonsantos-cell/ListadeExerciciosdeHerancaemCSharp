using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public abstract class Entrega
    {
        public double Distancia { get; set; }

        protected Entrega(double distancia)
        {
            Distancia = distancia;
        }
        public abstract double CalcularFrete();

    }
}
