using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja
{
    class Cajero : Persona
    {
        public Cajero(string nombre, int telefono) : base(nombre, telefono)
        {
            Console.WriteLine("el lee ama a windows");
            Console.WriteLine("holaa");
            Console.WriteLine("");
        }
    }
}
