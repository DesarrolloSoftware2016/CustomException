using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Radio
    {
        public Radio() { }

        public void Encender(bool on)
        {
            if (on)
                Console.WriteLine("Algo de música...");
            else
                Console.WriteLine("Silencio...");
        }
    }
}
