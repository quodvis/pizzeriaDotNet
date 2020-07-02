using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class FormCaja : Form
    {
        private double _totalRecaudado = 0;
        private double _total;
        DataTable data = new DataTable();
        private Producto _pizza = new Producto();
        private Producto _bebida = new Producto();
        LinqProductoDataContext dataContext = new LinqProductoDataContext();
        public FormCaja()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea cerrar caja?", "Cerrar Caja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Caja Cerrada \n Total recaudado: $" + _totalRecaudado.ToString());
                this.Close();
            }
        }
        private void FormCaja_Load(object sender, EventArgs e)
        {   
            dataGridViewTotal.DataSource = data;
            data.Columns.Add("Total");
            data.Rows.Add("");
        }
        private void checkedListBoxPizzas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            _pizza.nombre = null;
            _pizza.precio = 0;
            _pizza.cantidad = 0;
            if (e.NewValue == CheckState.Checked && checkedListBoxPizzas.CheckedItems.Count > 0)
            {
                checkedListBoxPizzas.ItemCheck -= checkedListBoxPizzas_ItemCheck;
                checkedListBoxPizzas.SetItemChecked(checkedListBoxPizzas.CheckedIndices[0], false);
                checkedListBoxPizzas.ItemCheck += checkedListBoxPizzas_ItemCheck;
            }            
            switch (checkedListBoxPizzas.SelectedIndex)
            {
                case 0:
                    _pizza.nombre = "Pizza Familiar";
                    _pizza.precio = 22000;
                    break;
                case 1:
                    _pizza.nombre = "Pizza Mediana";
                    _pizza.precio = 12000;
                    break;
                case 2:
                    _pizza.nombre = "Pizza Individual";
                    _pizza.precio = 8000;
                    break;
                default:
                    _pizza.precio = 0;
                    break;
            }
            _pizza.cantidad = (textBoxCantidad.Text == "Cantidad") ? 0 : int.Parse(textBoxCantidad.Text);
            _total = (_pizza.precio * _pizza.cantidad) + (_bebida.precio * _bebida.cantidad);
            data.Rows.Clear();
            data.Rows.Add(_total);            
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCantidad_Enter(object sender, EventArgs e)
        {
            if(textBoxCantidad.Text == "Cantidad")
            {
                textBoxCantidad.Text = "";
                textBoxCantidad.ForeColor = Color.Black;
            }
        }

        private void textBoxCantidad_Leave(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                textBoxCantidad.Text = "Cantidad";
                textBoxCantidad.ForeColor = Color.Silver;
                _pizza.cantidad = 0;
            }
        }
        private void checkedListBoxBebidas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            _bebida.nombre = null;
            _bebida.precio = 0;
            _bebida.cantidad = 0;
            if (e.NewValue == CheckState.Checked && checkedListBoxBebidas.CheckedItems.Count > 0)
            {
                checkedListBoxBebidas.ItemCheck -= checkedListBoxBebidas_ItemCheck;
                checkedListBoxBebidas.SetItemChecked(checkedListBoxBebidas.CheckedIndices[0], false);
                checkedListBoxBebidas.ItemCheck += checkedListBoxBebidas_ItemCheck;
            }
            switch (checkedListBoxBebidas.SelectedIndex)
            {
                case 0:
                    _bebida.nombre = "Bebida Individual";
                    _bebida.precio = 1500;
                    break;
                case 1:
                    _bebida.nombre = "Bebida Familiar";
                    _bebida.precio = 5000;
                    break;
                default:
                    _bebida.precio = 0;
                    break;
            }
            _bebida.cantidad = (textBoxCantidadBebidas.Text == "Cantidad") ? 0 : int.Parse(textBoxCantidadBebidas.Text);
            _total = (_pizza.precio * _pizza.cantidad) + (_bebida.precio * _bebida.cantidad);
            data.Rows.Clear();
            data.Rows.Add(_total);
        }
        private void textBoxCantidadBebidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxCantidadBebidas_Enter(object sender, EventArgs e)
        {
            if (textBoxCantidadBebidas.Text == "Cantidad")
            {
                textBoxCantidadBebidas.Text = "";
                textBoxCantidadBebidas.ForeColor = Color.Black;
            }
        }

        private void textBoxCantidadBebidas_Leave(object sender, EventArgs e)
        {
            if (textBoxCantidadBebidas.Text == "")
            {
                textBoxCantidadBebidas.Text = "Cantidad";
                textBoxCantidadBebidas.ForeColor = Color.Silver;
                _bebida.cantidad = 0;

            }
        }
        private void buttonAgregarPedido_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea agregar pedido?","Agregar Pedido", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _pizza.nombre = (_pizza.cantidad == 0) ? null : _pizza.nombre;
                _bebida.nombre = (_bebida.cantidad == 0) ? null : _bebida.nombre;
                LinqProductoDataContext dataContext = new LinqProductoDataContext();
                if (_pizza.nombre != null && _bebida.nombre != null)
                {
                    dataContext.Producto.InsertOnSubmit(_pizza);
                    dataContext.Producto.InsertOnSubmit(_bebida);
                }
                else if (_pizza.nombre != null)
                    dataContext.Producto.InsertOnSubmit(_pizza);
                else if (_bebida.nombre != null)
                    dataContext.Producto.InsertOnSubmit(_bebida);
                else
                {
                    MessageBox.Show("Producto o Cantidad no seleccionado");
                    return;
                }
                _totalRecaudado += (_pizza.precio * _pizza.cantidad) + (_bebida.precio * _bebida.cantidad);                
                dataContext.SubmitChanges();
                dataContext.Dispose();
                MessageBox.Show("Pedido Agregado");
            }            
        }
    }
}
