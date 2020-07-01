namespace Caja
{
    partial class FormCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCerrarCaja = new System.Windows.Forms.Button();
            this.dataGridViewTotal = new System.Windows.Forms.DataGridView();
            this.labelPizzaHat = new System.Windows.Forms.Label();
            this.labelPizzas = new System.Windows.Forms.Label();
            this.labelBebidas = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAgregarPedido = new System.Windows.Forms.Button();
            this.checkedListBoxPizzas = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxBebidas = new System.Windows.Forms.CheckedListBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxCantidadBebidas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrarCaja
            // 
            this.buttonCerrarCaja.Location = new System.Drawing.Point(287, 181);
            this.buttonCerrarCaja.Name = "buttonCerrarCaja";
            this.buttonCerrarCaja.Size = new System.Drawing.Size(84, 23);
            this.buttonCerrarCaja.TabIndex = 0;
            this.buttonCerrarCaja.Text = "Cerrar Caja";
            this.buttonCerrarCaja.UseVisualStyleBackColor = true;
            this.buttonCerrarCaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTotal
            // 
            this.dataGridViewTotal.AllowUserToAddRows = false;
            this.dataGridViewTotal.AllowUserToDeleteRows = false;
            this.dataGridViewTotal.AllowUserToResizeColumns = false;
            this.dataGridViewTotal.AllowUserToResizeRows = false;
            this.dataGridViewTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTotal.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotal.Location = new System.Drawing.Point(72, 247);
            this.dataGridViewTotal.Name = "dataGridViewTotal";
            this.dataGridViewTotal.ReadOnly = true;
            this.dataGridViewTotal.RowHeadersVisible = false;
            this.dataGridViewTotal.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewTotal.Size = new System.Drawing.Size(65, 47);
            this.dataGridViewTotal.TabIndex = 2;
            // 
            // labelPizzaHat
            // 
            this.labelPizzaHat.AutoSize = true;
            this.labelPizzaHat.Location = new System.Drawing.Point(203, 9);
            this.labelPizzaHat.Name = "labelPizzaHat";
            this.labelPizzaHat.Size = new System.Drawing.Size(76, 13);
            this.labelPizzaHat.TabIndex = 3;
            this.labelPizzaHat.Text = "Pizza Hat SPA";
            // 
            // labelPizzas
            // 
            this.labelPizzas.AutoSize = true;
            this.labelPizzas.Location = new System.Drawing.Point(69, 74);
            this.labelPizzas.Name = "labelPizzas";
            this.labelPizzas.Size = new System.Drawing.Size(37, 13);
            this.labelPizzas.TabIndex = 4;
            this.labelPizzas.Text = "Pizzas";
            // 
            // labelBebidas
            // 
            this.labelBebidas.AutoSize = true;
            this.labelBebidas.Location = new System.Drawing.Point(284, 74);
            this.labelBebidas.Name = "labelBebidas";
            this.labelBebidas.Size = new System.Drawing.Size(45, 13);
            this.labelBebidas.TabIndex = 5;
            this.labelBebidas.Text = "Bebidas";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            // 
            // buttonAgregarPedido
            // 
            this.buttonAgregarPedido.Location = new System.Drawing.Point(72, 181);
            this.buttonAgregarPedido.Name = "buttonAgregarPedido";
            this.buttonAgregarPedido.Size = new System.Drawing.Size(99, 23);
            this.buttonAgregarPedido.TabIndex = 11;
            this.buttonAgregarPedido.Text = "Agregar Pedido";
            this.buttonAgregarPedido.UseVisualStyleBackColor = true;
            this.buttonAgregarPedido.Click += new System.EventHandler(this.buttonAgregarPedido_Click);
            // 
            // checkedListBoxPizzas
            // 
            this.checkedListBoxPizzas.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxPizzas.CheckOnClick = true;
            this.checkedListBoxPizzas.FormattingEnabled = true;
            this.checkedListBoxPizzas.Items.AddRange(new object[] {
            "Familiar $22.000",
            "Mediana $12.000",
            "Individual $8.000"});
            this.checkedListBoxPizzas.Location = new System.Drawing.Point(72, 126);
            this.checkedListBoxPizzas.Name = "checkedListBoxPizzas";
            this.checkedListBoxPizzas.Size = new System.Drawing.Size(110, 49);
            this.checkedListBoxPizzas.TabIndex = 18;
            this.checkedListBoxPizzas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPizzas_ItemCheck);
            // 
            // checkedListBoxBebidas
            // 
            this.checkedListBoxBebidas.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxBebidas.CheckOnClick = true;
            this.checkedListBoxBebidas.FormattingEnabled = true;
            this.checkedListBoxBebidas.Items.AddRange(new object[] {
            "Individual $1.500",
            "Familiar $5.000"});
            this.checkedListBoxBebidas.Location = new System.Drawing.Point(287, 126);
            this.checkedListBoxBebidas.Name = "checkedListBoxBebidas";
            this.checkedListBoxBebidas.Size = new System.Drawing.Size(111, 34);
            this.checkedListBoxBebidas.TabIndex = 20;
            this.checkedListBoxBebidas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxBebidas_ItemCheck);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCantidad.Location = new System.Drawing.Point(72, 100);
            this.textBoxCantidad.MaxLength = 2;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(51, 20);
            this.textBoxCantidad.TabIndex = 21;
            this.textBoxCantidad.Tag = "";
            this.textBoxCantidad.Text = "Cantidad";
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCantidad.Enter += new System.EventHandler(this.textBoxCantidad_Enter);
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            this.textBoxCantidad.Leave += new System.EventHandler(this.textBoxCantidad_Leave);
            // 
            // textBoxCantidadBebidas
            // 
            this.textBoxCantidadBebidas.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCantidadBebidas.Location = new System.Drawing.Point(287, 100);
            this.textBoxCantidadBebidas.MaxLength = 2;
            this.textBoxCantidadBebidas.Name = "textBoxCantidadBebidas";
            this.textBoxCantidadBebidas.Size = new System.Drawing.Size(51, 20);
            this.textBoxCantidadBebidas.TabIndex = 22;
            this.textBoxCantidadBebidas.Text = "Cantidad";
            this.textBoxCantidadBebidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCantidadBebidas.Enter += new System.EventHandler(this.textBoxCantidadBebidas_Enter);
            this.textBoxCantidadBebidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidadBebidas_KeyPress);
            this.textBoxCantidadBebidas.Leave += new System.EventHandler(this.textBoxCantidadBebidas_Leave);
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 322);
            this.Controls.Add(this.textBoxCantidadBebidas);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.checkedListBoxBebidas);
            this.Controls.Add(this.checkedListBoxPizzas);
            this.Controls.Add(this.buttonAgregarPedido);
            this.Controls.Add(this.labelBebidas);
            this.Controls.Add(this.labelPizzas);
            this.Controls.Add(this.labelPizzaHat);
            this.Controls.Add(this.dataGridViewTotal);
            this.Controls.Add(this.buttonCerrarCaja);
            this.Name = "FormCaja";
            this.ShowIcon = false;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FormCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrarCaja;
        private System.Windows.Forms.DataGridView dataGridViewTotal;
        private System.Windows.Forms.Label labelPizzaHat;
        private System.Windows.Forms.Label labelPizzas;
        private System.Windows.Forms.Label labelBebidas;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Button buttonAgregarPedido;
        private System.Windows.Forms.CheckedListBox checkedListBoxPizzas;
        private System.Windows.Forms.CheckedListBox checkedListBoxBebidas;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxCantidadBebidas;
    }
}