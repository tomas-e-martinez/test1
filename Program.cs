using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOrepaso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();

            int sumaEdades, edadMaxima, edadMinima;

            Hombre hombre1 = new Hombre();
            hombre1.Saludar();

            for (int i = 0; i < 119; i++)
            {
                listaPersonas.Add(new Persona());
            }
            listaPersonas.ForEach(persaaaona => persaaaona.Edad+=5);

            sumaEdades = listaPersonas.Sum(Personqa => Personqa.Edad);
            edadMaxima = listaPersonas.Max(Persona => Persona.Edad);
            edadMinima = listaPersonas.Min(Persona => Persona.Edad);

            listaPersonas[0].Saludar();



            Console.WriteLine("Hay " + listaPersonas.Count + " personas.");
            Console.WriteLine("El promedio de edad es " + sumaEdades / listaPersonas.Count  + ".");
            Console.WriteLine("La edad más alta es " + edadMaxima + ".");
            Console.WriteLine("La edad más baja es " + edadMinima + ".");
            Console.ReadKey();
        }
    }
}
