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
            ((System.ComponentModel.ISupportInitialize)GridProductosList).BeginInit();
            SuspendLayout();
            // 
            // GridProductosList
            // 
            GridProductosList.AllowUserToAddRows = false;
            GridProductosList.AllowUserToDeleteRows = false;
            GridProductosList.BackgroundColor = Color.Lavender;
            GridProductosList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProductosList.Location = new Point(12, 76);
            GridProductosList.Name = "GridProductosList";
            GridProductosList.ReadOnly = true;
            GridProductosList.RowHeadersWidth = 62;
            GridProductosList.Size = new Size(641, 346);
            GridProductosList.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(676, 96);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(112, 34);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(676, 165);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(112, 34);
            BtnModificar.TabIndex = 2;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(676, 234);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 34);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(716, 404);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(72, 34);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // ListProductosView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSalir);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnAgregar);
            Controls.Add(GridProductosList);
            Name = "ListProductosView";
            Text = "ListProductosView";
            ((System.ComponentModel.ISupportInitialize)GridProductosList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridProductosList;
        private Button BtnAgregar;
        private Button BtnModificar;
        private Button BtnEliminar;
        private Button BtnSalir;
    }
}