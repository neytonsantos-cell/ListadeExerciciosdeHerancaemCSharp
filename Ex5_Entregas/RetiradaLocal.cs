using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class RetiradaLocal : Entrega
    {
        public RetiradaLocal() : base(0) { }

        public override double CalcularFrete()
        {
            return 0;
        }
    }
}