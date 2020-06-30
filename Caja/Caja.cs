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
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaDBDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.pizzeriaDBDataSet.Producto);

        }

        private void checkedListBoxBebidas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBoxBebidas.CheckedItems.Count > 0)
            {
                checkedListBoxBebidas.ItemCheck -= checkedListBoxBebidas_ItemCheck;
                checkedListBoxBebidas.SetItemChecked(checkedListBoxBebidas.CheckedIndices[0], false);
                checkedListBoxBebidas.ItemCheck += checkedListBoxBebidas_ItemCheck;
            }
        }

        private void checkedListBoxPizzas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBoxPizzas.CheckedItems.Count > 0)
            {
                checkedListBoxPizzas.ItemCheck -= checkedListBoxPizzas_ItemCheck;
                checkedListBoxPizzas.SetItemChecked(checkedListBoxPizzas.CheckedIndices[0], false);
                checkedListBoxPizzas.ItemCheck += checkedListBoxPizzas_ItemCheck;
            }
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
    }
}
