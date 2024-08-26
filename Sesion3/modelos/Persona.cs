using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3.modelos
{
    internal class Persona
    {
        public Persona() { }

        public string Name { get; set; }

        public DateTime FechaNac { get; set; }

        public int CalcularEdad()
        {
            // return DateTime.Now.Year - FechaNac.Year;
            int edad = 0;
            try     // intentar lo que está dentro de la llave
            {
                edad = DateTime.Now.Year - FechaNac.Year;
            }
            catch (Exception ex)    // cachar excepción de dato ingresado
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
            return edad;
        }

        public string EvaluarEdad()
        {
            if (CalcularEdad() >= 18) return "Mayor de edad";
            return "Menor de edad";
        }
    }
}
