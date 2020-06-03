using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Todo lo referido a la venta, se declara en esta clase
namespace Caja
{
    enum TipoEntrega
    {
        DESPACHO,LOCAL
    }

    enum TipoPago
    {
        EFECTIVO, TRANFERENCIA
    }

    class Pedido
    {
        private int _fecha;//Funciona como Id

        private readonly ArrayList _productos;

        private double _monto;

        private Cajero _cajero;

        private Repartidor _repartidor;

        private Cliente _cliente;



        public Pedido(ArrayList productos)

        {

            _fecha = System.DateTime.Now.Millisecond;

            Console.WriteLine("EPOCH: " + _fecha); // Mostrara en pantalla si el metodo funciona

            _monto = .0;

            _productos = productos;

            MontoTotal();

        }

        public ArrayList Productos => _productos;


        //Gets&Sets
        public double Monto
        {

            get => _monto;

            private set

            {
                //Verifica que el monto no sea negativo
                _monto = Math.Abs(value);

            }

        }



        public int Fecha { get => _fecha; set => _fecha = value; }

        internal Cajero Cajero { get => _cajero; set => _cajero = value; }

        internal Repartidor Repartidor { get => _repartidor; set => _repartidor = value; }

        internal Cliente Cliente { get => _cliente; set => _cliente = value; }



        // CUSTOM

        private void MontoTotal()

        {

            // Suma para el monto total

            foreach (Producto p in _productos)

                Monto = (p.Precio + Monto);

        }



        // Traduccion booleana

        public string ServirODespacho()

        {

            return _repartidor == null ? "Para servir o llevar" : "Despacho a domicilio";

        }

    }
}
}
