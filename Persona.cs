using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOrepaso2
{
    internal class Persona
    {
        private static Random random = new Random();
        public Persona() 
        {
            Edad = random.Next(0, 91);
        }

        public virtual void Saludar()
        {
            //comentario test commit 2
            Console.WriteLine("Hola, soy una persona y tengo " +  Edad + " años.");
        }

        public int Edad { get; set; }
    }
}
