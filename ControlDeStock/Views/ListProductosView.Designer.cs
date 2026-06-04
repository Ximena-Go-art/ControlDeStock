namespace ControlDeStock.Views
{
    partial class ListProductosView
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
            GridProductosList = new DataGridView();
            BtnAgregar = new Button();
            BtnModificar = new Button();
            BtnEliminar = new Button();
            BtnSalir = new Button();
            TabGeneral = new TabControl();
            TabListaProductos = new TabPage();
            BtnBuscar = new Button();
            TxtBuscar = new TextBox();
            TabAgregarModificar = new TabPage();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            NumPrecio = new NumericUpDown();
            NumStockActual = new NumericUpDown();
            TxtCategoria = new TextBox();
            TxtNombre = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)GridProductosList).BeginInit();
            TabGeneral.SuspendLayout();
            TabListaProductos.SuspendLayout();
            TabAgregarModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumStockActual).BeginInit();
            SuspendLayout();
            // 
            // GridProductosList
            // 
            GridProductosList.AllowUserToAddRows = false;
            GridProductosList.AllowUserToDeleteRows = false;
            GridProductosList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridProductosList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridProductosList.BackgroundColor = Color.Lavender;
            GridProductosList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProductosList.Location = new Point(4, 34);
            GridProductosList.Margin = new Padding(2);
            GridProductosList.MultiSelect = false;
            GridProductosList.Name = "GridProductosList";
            GridProductosList.ReadOnly = true;
            GridProductosList.RowHeadersWidth = 62;
            GridProductosList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridProductosList.Size = new Size(458, 223);
            GridProductosList.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Right;
            BtnAgregar.Location = new Point(478, 85);
            BtnAgregar.Margin = new Padding(2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(78, 25);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Right;
            BtnModificar.Location = new Point(478, 127);
            BtnModificar.Margin = new Padding(2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(78, 25);
            BtnModificar.TabIndex = 2;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Right;
            BtnEliminar.Location = new Point(478, 169);
            BtnEliminar.Margin = new Padding(2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(78, 25);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom;
            BtnSalir.Location = new Point(520, 232);
            BtnSalir.Margin = new Padding(2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(50, 20);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // TabGeneral
            // 
            TabGeneral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabGeneral.Controls.Add(TabListaProductos);
            TabGeneral.Controls.Add(TabAgregarModificar);
            TabGeneral.Location = new Point(2, 36);
            TabGeneral.Margin = new Padding(2);
            TabGeneral.Name = "TabGeneral";
            TabGeneral.SelectedIndex = 0;
            TabGeneral.Size = new Size(587, 287);
            TabGeneral.TabIndex = 5;
            TabGeneral.Tag = "TabControl";
            // 
            // TabListaProductos
            // 
            TabListaProductos.Controls.Add(BtnBuscar);
            TabListaProductos.Controls.Add(TxtBuscar);
            TabListaProductos.Controls.Add(GridProductosList);
            TabListaProductos.Controls.Add(BtnSalir);
            TabListaProductos.Controls.Add(BtnAgregar);
            TabListaProductos.Controls.Add(BtnEliminar);
            TabListaProductos.Controls.Add(BtnModificar);
            TabListaProductos.Location = new Point(4, 24);
            TabListaProductos.Margin = new Padding(2);
            TabListaProductos.Name = "TabListaProductos";
            TabListaProductos.Padding = new Padding(2);
            TabListaProductos.Size = new Size(579, 259);
            TabListaProductos.TabIndex = 0;
            TabListaProductos.Text = "Lista de Productos";
            TabListaProductos.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Right;
            BtnBuscar.Location = new Point(478, 5);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(78, 25);
            BtnBuscar.TabIndex = 8;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(6, 5);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(452, 23);
            TxtBuscar.TabIndex = 7;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // TabAgregarModificar
            // 
            TabAgregarModificar.BackColor = Color.Lavender;
            TabAgregarModificar.Controls.Add(BtnCancelar);
            TabAgregarModificar.Controls.Add(BtnGuardar);
            TabAgregarModificar.Controls.Add(label4);
            TabAgregarModificar.Controls.Add(label3);
            TabAgregarModificar.Controls.Add(label2);
            TabAgregarModificar.Controls.Add(label1);
            TabAgregarModificar.Controls.Add(NumPrecio);
            TabAgregarModificar.Controls.Add(NumStockActual);
            TabAgregarModificar.Controls.Add(TxtCategoria);
            TabAgregarModificar.Controls.Add(TxtNombre);
            TabAgregarModificar.Location = new Point(4, 24);
            TabAgregarModificar.Margin = new Padding(2);
            TabAgregarModificar.Name = "TabAgregarModificar";
            TabAgregarModificar.Padding = new Padding(2);
            TabAgregarModificar.Size = new Size(579, 259);
            TabAgregarModificar.TabIndex = 1;
            TabAgregarModificar.Text = "Agregar/Modificar";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(300, 178);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(70, 23);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click_1;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(172, 178);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(70, 23);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 132);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 7;
            label4.Text = "Stock Actual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 132);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 65);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // NumPrecio
            // 
            NumPrecio.Location = new Point(122, 130);
            NumPrecio.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumPrecio.Name = "NumPrecio";
            NumPrecio.Size = new Size(120, 23);
            NumPrecio.TabIndex = 3;
            // 
            // NumStockActual
            // 
            NumStockActual.Location = new Point(361, 130);
            NumStockActual.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumStockActual.Name = "NumStockActual";
            NumStockActual.Size = new Size(120, 23);
            NumStockActual.TabIndex = 2;
            // 
            // TxtCategoria
            // 
            TxtCategoria.Location = new Point(131, 62);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(350, 23);
            TxtCategoria.TabIndex = 1;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(131, 24);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(350, 23);
            TxtNombre.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SkyBlue;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 31);
            panel1.TabIndex = 6;
            // 
            // ListProductosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 323);
            Controls.Add(TabGeneral);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ListProductosView";
            Text = "ListProductosView";
            ((System.ComponentModel.ISupportInitialize)GridProductosList).EndInit();
            TabGeneral.ResumeLayout(false);
            TabListaProductos.ResumeLayout(false);
            TabListaProductos.PerformLayout();
            TabAgregarModificar.ResumeLayout(false);
            TabAgregarModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumStockActual).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridProductosList;
        private Button BtnAgregar;
        private Button BtnModificar;
        private Button BtnEliminar;
        private Button BtnSalir;
        private TabControl TabGeneral;
        private TabPage TabListaProductos;
        private TabPage TabAgregarModificar;
        private Panel panel1;
        private NumericUpDown NumStockActual;
        private TextBox TxtCategoria;
        private TextBox TxtNombre;
        private NumericUpDown NumPrecio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private TextBox TxtBuscar;
        private Button BtnBuscar;
    }
}