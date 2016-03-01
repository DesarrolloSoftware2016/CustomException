using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Excepciones Personalizadas *****\n");
            Vehiculo miVehiculo = new Vehiculo("Carcachita", 120);

            try
            {
                // Lanzar excepción
                miVehiculo.Acelerar(-15);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Esto ocurrirá independientemente de si sucede
                // una excepción o no...
                miVehiculo.UtilizarRadio(false);
            }

            Console.ReadLine();
        }
    }
}
