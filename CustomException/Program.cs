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
                miVehiculo.Acelerar(1500);
            }
            catch (VehiculoMuertoException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CausaError);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // Una captura de otro tipo de excepción
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Una captura genérica
            catch
            {
                Console.WriteLine("Algo malo sucedió al acelerar...");
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
