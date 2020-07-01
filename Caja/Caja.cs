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
        private int _costoPizzas;
        private int _costoBebidas;
        private int _total;
        DataTable data = new DataTable();
        public FormCaja()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {   
            dataGridViewTotal.DataSource = data;
            data.Columns.Add("Total");
            data.Rows.Add("");
        }

        private void checkedListBoxBebidas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBoxBebidas.CheckedItems.Count > 0)
            {
                checkedListBoxBebidas.ItemCheck -= checkedListBoxBebidas_ItemCheck;
                checkedListBoxBebidas.SetItemChecked(checkedListBoxBebidas.CheckedIndices[0], false);
                checkedListBoxBebidas.ItemCheck += checkedListBoxBebidas_ItemCheck;
            }
            switch (checkedListBoxBebidas.SelectedIndex)
            {
                case 0:
                    _costoBebidas = 1500;
                    break;
                case 1:
                    _costoBebidas = 5000;
                    break;
                default:
                    _costoBebidas = 0;
                    break;
            }
            _costoBebidas = (textBoxCantidadBebidas.Text == "Cantidad") ? 0 : _costoBebidas * int.Parse(textBoxCantidadBebidas.Text);            
            _total = _costoBebidas + _costoPizzas;
            data.Rows.Clear();
            data.Rows.Add(_total);
        }

        private void checkedListBoxPizzas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBoxPizzas.CheckedItems.Count > 0)
            {
                checkedListBoxPizzas.ItemCheck -= checkedListBoxPizzas_ItemCheck;
                checkedListBoxPizzas.SetItemChecked(checkedListBoxPizzas.CheckedIndices[0], false);
                checkedListBoxPizzas.ItemCheck += checkedListBoxPizzas_ItemCheck;
            }            
            switch (checkedListBoxPizzas.SelectedIndex)
            {
                case 0:
                    _costoPizzas = 22000;
                    break;
                case 1:
                    _costoPizzas = 12000;
                    break;
                case 2:
                    _costoPizzas = 8000;
                    break;
                default:
                    _costoPizzas = 0;
                    break;
            }
            _costoPizzas = (textBoxCantidad.Text == "Cantidad") ? 0 : _costoPizzas * int.Parse(textBoxCantidad.Text);            
            _total = _costoPizzas + _costoBebidas;
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
            }
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
            }
        }

        private void buttonAgregarPedido_Click(object sender, EventArgs e)
        {
            LinqProductoDataContext dataContext = new LinqProductoDataContext();
            Producto pizza = new Producto();
            pizza.nombre = "";
            pizza.precio = 22000;
            pizza.cantidad = 1;
            dataContext.Producto.InsertOnSubmit(pizza);
            dataContext.SubmitChanges();
        }
    }
}
