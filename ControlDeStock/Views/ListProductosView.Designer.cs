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
            TabListaProductos = new TabControl();
            TabLista = new TabPage();
            tabAgregarModificar = new TabPage();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)GridProductosList).BeginInit();
            TabListaProductos.SuspendLayout();
            TabLista.SuspendLayout();
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
            GridProductosList.Location = new Point(6, 3);
            GridProductosList.MultiSelect = false;
            GridProductosList.Name = "GridProductosList";
            GridProductosList.ReadOnly = true;
            GridProductosList.RowHeadersWidth = 62;
            GridProductosList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridProductosList.Size = new Size(616, 357);
            GridProductosList.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Right;
            BtnAgregar.Location = new Point(644, 45);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(112, 34);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Right;
            BtnModificar.Location = new Point(644, 110);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(112, 34);
            BtnModificar.TabIndex = 2;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Right;
            BtnEliminar.Location = new Point(644, 186);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 34);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom;
            BtnSalir.Location = new Point(710, 326);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(72, 34);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // TabListaProductos
            // 
            TabListaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabListaProductos.Controls.Add(TabLista);
            TabListaProductos.Controls.Add(tabAgregarModificar);
            TabListaProductos.Location = new Point(1, 44);
            TabListaProductos.Name = "TabListaProductos";
            TabListaProductos.SelectedIndex = 0;
            TabListaProductos.Size = new Size(796, 404);
            TabListaProductos.TabIndex = 5;
            TabListaProductos.Tag = "Lista de Productos";
            // 
            // TabLista
            // 
            TabLista.Controls.Add(GridProductosList);
            TabLista.Controls.Add(BtnSalir);
            TabLista.Controls.Add(BtnAgregar);
            TabLista.Controls.Add(BtnEliminar);
            TabLista.Controls.Add(BtnModificar);
            TabLista.Location = new Point(4, 34);
            TabLista.Name = "TabLista";
            TabLista.Padding = new Padding(3);
            TabLista.Size = new Size(788, 366);
            TabLista.TabIndex = 0;
            TabLista.Text = "Lista de Productos";
            TabLista.UseVisualStyleBackColor = true;
            // 
            // tabAgregarModificar
            // 
            tabAgregarModificar.Location = new Point(4, 34);
            tabAgregarModificar.Name = "tabAgregarModificar";
            tabAgregarModificar.Padding = new Padding(3);
            tabAgregarModificar.Size = new Size(788, 366);
            tabAgregarModificar.TabIndex = 1;
            tabAgregarModificar.Text = "Agregar/Modificar";
            tabAgregarModificar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 6;
            // 
            // ListProductosView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabListaProductos);
            Controls.Add(panel1);
            Name = "ListProductosView";
            Text = "ListProductosView";
            ((System.ComponentModel.ISupportInitialize)GridProductosList).EndInit();
            TabListaProductos.ResumeLayout(false);
            TabLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridProductosList;
        private Button BtnAgregar;
        private Button BtnModificar;
        private Button BtnEliminar;
        private Button BtnSalir;
        private TabControl TabListaProductos;
        private TabPage TabLista;
        private TabPage tabAgregarModificar;
        private Panel panel1;
    }
}