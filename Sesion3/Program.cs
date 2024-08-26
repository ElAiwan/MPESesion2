using Sesion3.modelos;

namespace Sesion3
{
    internal class Program
    {
        /* Calcular la edad de una persona y decir si es mayor o menor de edad */

        static void Main(string[] args)
        {
            Persona persona = new Persona();
            string name;
            DateTime fechaNac;

            Console.WriteLine("Nombre: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Fecha de nacimiento: ");
            fechaNac = DateTime.Parse(Console.ReadLine());  // Utilizar plecas "/" para las fechas. Ej.: 25/08/1998

            persona.Name = name;
            persona.FechaNac = fechaNac;
            Console.WriteLine(persona.EvaluarEdad());
        }
    }
}
