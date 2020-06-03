using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja
{
    abstract class Persona
    {
        private string _nombre;

        private int _telefono;

        protected Persona(string nombre, int telefono)

        {

            Nombre = nombre;

            Telefono = telefono;

        }
        public string Nombre
        {

            get => _nombre;

            set

            {
                //validacion largo del nombre
                if (value.Length < 100 && value.Length > 3)

                    _nombre = value;

            }

        }

        public int Telefono
        {

            get => _telefono;

            set

            {

                string tmpTelefono = value.ToString();

                //validacion largo del numero
                if (tmpTelefono.Length == 9)
                    //Validacion para que no venga en negativo
                    _telefono = Math.Abs(value);

            }
        }
    }
}

