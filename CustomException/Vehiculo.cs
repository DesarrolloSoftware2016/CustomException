using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Vehiculo
    {
        // Constante para velocidad máxima
        public const int VelocidadMaxima = 200;

        // Propiedades del vehículo
        public int VelocidadActual { get; set; }
        public string Apodo { get; set; }

        // El vehículo es funcional?
        private bool vehiculoMuerto;

        // El vehículo tiene una radio
        private Radio elRadio = new Radio();

        // Constructores
        public Vehiculo() { }
        public Vehiculo(string apodo, int velocidad)
        {
            VelocidadActual = velocidad;
            Apodo = apodo;
        }

        public void UtilizarRadio(bool estado)
        {
            // Delegar el objeto interno
            elRadio.Encender(estado);
        }

        // Ver si el vehículo se encuentra sobrecalentado
        // Esta vez, lanzaremos una excepción si el usuario acelera
        // después de la velocidad máxima
        public void Acelerar(int delta)
        {
            if (delta <= 0)
                throw new ArgumentOutOfRangeException("delta", "!La velocidad debe ser mayor que cero!");

            if (vehiculoMuerto)
                Console.WriteLine("{0} está fuera de servicio...", Apodo);
            else
            {
                VelocidadActual += delta;

                if (VelocidadActual > VelocidadMaxima)
                {
                    VelocidadActual = 0;
                    vehiculoMuerto = true;

                    // Utilizar la palabra reservada "throw"para lanzar una excepción
                    VehiculoMuertoException ex = new VehiculoMuertoException(string.Format("¡{0} se ha sobrecalentado!", Apodo), "No dejaste de acelerar", DateTime.Now);
                    ex.HelpLink = "http://desarrollodesoftware.edu";
                    throw ex;
                }
                else
                    Console.WriteLine("=> Velocidad Actual = {0}", VelocidadActual);
            }
        }
    }
}
