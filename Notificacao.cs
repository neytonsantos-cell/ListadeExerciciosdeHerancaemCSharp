using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListadeExerciciosdeHerancaemCSharp
{
    public class Notificacao
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Enviando notificação genérica...");
        }
    }
}