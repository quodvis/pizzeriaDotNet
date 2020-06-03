using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja
{
    enum TipoProducto

    {

        PROMO1

    }



    class Producto

    {
        //Atributos
        private int _id;

        private double _precio;

        private double _descuento;

        private TipoProducto _tipoProducto;


    //Contructor por defecto
    public Producto()

    {

        _id = -1;

        _precio = 10000;

        _descuento = .0;

        _tipoProducto = TipoProducto.PROMO1;

    }



    // Gets&Sets

    public double Descuento

    {

        get => _descuento;

        set

        {
            //Validacion del descuento
            if (value > 0 && value <= 100)

                _descuento = value;

        }

    }



    public double Precio { get => _precio; set => _precio = value; }

    public int Id
    {

        get => _id;
        //Validacion id no venga en negativ
        set => _id = Math.Abs(value);

    }

    internal TipoProducto TipoProducto { get => _tipoProducto; set => _tipoProducto = value; }

}
}
