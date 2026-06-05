namespace ControlDeStock.Views
{
    partial class ListaMovimientosView
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
            GridMovimientosLista = new DataGridView();
            BtnAgregar = new Button();
            BtnModificar = new Button();
            BtnEliminar = new Button();
            BtnSalir = new Button();
            TabGeneral = new TabControl();
            TabListaMovimientos = new TabPage();
            BtnBuscar = new Button();
            TxtBuscar = new TextBox();
            TabAgregarModificar = new TabPage();
            DtFechaMovimiento = new DateTimePicker();
            CbTipoMovimiento = new ComboBox();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            NumCantidad = new NumericUpDown();
            panel1 = new Panel();
            label5 = new Label();
            CbProducto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GridMovimientosLista).BeginInit();
            TabGeneral.SuspendLayout();
            TabListaMovimientos.SuspendLayout();
            TabAgregarModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GridMovimientosLista
            // 
            GridMovimientosLista.AllowUserToAddRows = false;
            GridMovimientosLista.AllowUserToDeleteRows = false;
            GridMovimientosLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridMovimientosLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridMovimientosLista.BackgroundColor = Color.Lavender;
            GridMovimientosLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMovimientosLista.Location = new Point(4, 34);
            GridMovimientosLista.Margin = new Padding(2);
            GridMovimientosLista.MultiSelect = false;
            GridMovimientosLista.Name = "GridMovimientosLista";
            GridMovimientosLista.ReadOnly = true;
            GridMovimientosLista.RowHeadersWidth = 62;
            GridMovimientosLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridMovimientosLista.Size = new Size(458, 223);
            GridMovimientosLista.TabIndex = 0;
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
            TabGeneral.Controls.Add(TabListaMovimientos);
            TabGeneral.Controls.Add(TabAgregarModificar);
            TabGeneral.Location = new Point(2, 36);
            TabGeneral.Margin = new Padding(2);
            TabGeneral.Name = "TabGeneral";
            TabGeneral.SelectedIndex = 0;
            TabGeneral.Size = new Size(587, 287);
            TabGeneral.TabIndex = 5;
            TabGeneral.Tag = "TabControl";
            // 
            // TabListaMovimientos
            // 
            TabListaMovimientos.Controls.Add(BtnBuscar);
            TabListaMovimientos.Controls.Add(TxtBuscar);
            TabListaMovimientos.Controls.Add(GridMovimientosLista);
            TabListaMovimientos.Controls.Add(BtnSalir);
            TabListaMovimientos.Controls.Add(BtnAgregar);
            TabListaMovimientos.Controls.Add(BtnEliminar);
            TabListaMovimientos.Controls.Add(BtnModificar);
            TabListaMovimientos.Location = new Point(4, 24);
            TabListaMovimientos.Margin = new Padding(2);
            TabListaMovimientos.Name = "TabListaMovimientos";
            TabListaMovimientos.Padding = new Padding(2);
            TabListaMovimientos.Size = new Size(579, 259);
            TabListaMovimientos.TabIndex = 0;
            TabListaMovimientos.Text = "Lista de Movimientos";
            TabListaMovimientos.UseVisualStyleBackColor = true;
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
            TabAgregarModificar.Controls.Add(CbProducto);
            TabAgregarModificar.Controls.Add(DtFechaMovimiento);
            TabAgregarModificar.Controls.Add(CbTipoMovimiento);
            TabAgregarModificar.Controls.Add(BtnCancelar);
            TabAgregarModificar.Controls.Add(BtnGuardar);
            TabAgregarModificar.Controls.Add(label4);
            TabAgregarModificar.Controls.Add(label3);
            TabAgregarModificar.Controls.Add(label2);
            TabAgregarModificar.Controls.Add(label1);
            TabAgregarModificar.Controls.Add(NumCantidad);
            TabAgregarModificar.Location = new Point(4, 24);
            TabAgregarModificar.Margin = new Padding(2);
            TabAgregarModificar.Name = "TabAgregarModificar";
            TabAgregarModificar.Padding = new Padding(2);
            TabAgregarModificar.Size = new Size(579, 259);
            TabAgregarModificar.TabIndex = 1;
            TabAgregarModificar.Text = "Agregar/Modificar";
            // 
            // DtFechaMovimiento
            // 
            DtFechaMovimiento.Location = new Point(131, 153);
            DtFechaMovimiento.Name = "DtFechaMovimiento";
            DtFechaMovimiento.Size = new Size(230, 23);
            DtFechaMovimiento.TabIndex = 11;
            // 
            // CbTipoMovimiento
            // 
            CbTipoMovimiento.FormattingEnabled = true;
            CbTipoMovimiento.Location = new Point(131, 70);
            CbTipoMovimiento.Name = "CbTipoMovimiento";
            CbTipoMovimiento.Size = new Size(238, 23);
            CbTipoMovimiento.TabIndex = 10;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(299, 205);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(70, 23);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click_1;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(181, 205);
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
            label4.Location = new Point(82, 159);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 110);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Movimiento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Producto:";
            // 
            // NumCantidad
            // 
            NumCantidad.Location = new Point(131, 110);
            NumCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumCantidad.Name = "NumCantidad";
            NumCantidad.Size = new Size(120, 23);
            NumCantidad.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 31);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 5);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 0;
            label5.Text = "Lista de movimientos";
            // 
            // CbProducto
            // 
            CbProducto.FormattingEnabled = true;
            CbProducto.Location = new Point(131, 29);
            CbProducto.Name = "CbProducto";
            CbProducto.Size = new Size(238, 23);
            CbProducto.TabIndex = 12;
            // 
            // ListaMovimientosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 323);
            Controls.Add(TabGeneral);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ListaMovimientosView";
            Text = "ListaMovimientosView";
            ((System.ComponentModel.ISupportInitialize)GridMovimientosLista).EndInit();
            TabGeneral.ResumeLayout(false);
            TabListaMovimientos.ResumeLayout(false);
            TabListaMovimientos.PerformLayout();
            TabAgregarModificar.ResumeLayout(false);
            TabAgregarModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridMovimientosLista;
        private Button BtnAgregar;
        private Button BtnModificar;
        private Button BtnEliminar;
        private Button BtnSalir;
        private TabControl TabGeneral;
        private TabPage TabListaMovimientos;
        private TabPage TabAgregarModificar;
        private Panel panel1;
        private NumericUpDown NumCantidad;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private TextBox TxtBuscar;
        private Button BtnBuscar;
        private Label label5;
        private ComboBox CbTipoMovimiento;
        private DateTimePicker DtFechaMovimiento;
        private ComboBox CbProducto;
    }
}