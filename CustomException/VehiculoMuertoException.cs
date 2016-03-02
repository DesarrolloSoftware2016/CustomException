using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class VehiculoMuertoException : ApplicationException
    {
        private string detallesMensaje = String.Empty;

        // Propiedades
        public DateTime ErrorTimeStamp { get; set; }
        public string CausaError { get; set; }

        public VehiculoMuertoException() { }

        public VehiculoMuertoException(string mensaje, string causa, DateTime tiempo)
            :base(mensaje)
        {
            CausaError = causa;
            ErrorTimeStamp = tiempo;
        }

        // Sobreescribir la propiedad Exception.Message
        public override string Message
        {
            get
            {
                return string.Format("Mensaje de error en el vehículo: {0}", detallesMensaje);
            }
        }
    }
}
