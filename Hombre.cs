using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOrepaso2
{
    internal class Hombre : Persona
    {
        public override void Saludar()
        {
            Console.WriteLine("Hola, soy un hombre y tengo " + Edad + " años.");
        }
    }
}
