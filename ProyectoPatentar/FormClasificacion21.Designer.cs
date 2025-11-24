namespace ProyectoPatentar
{
    partial class FormClasificacion21
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionProductos = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.txtClaseNumero = new System.Windows.Forms.TextBox();
            this.lblTipoMarca = new System.Windows.Forms.Label();
            this.dgvClasificacion = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colClaseNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(274, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 43);
            this.label5.TabIndex = 90;
            this.label5.Text = "Clasificacion";
            // 
            // txtDescripcionProductos
            // 
            this.txtDescripcionProductos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescripcionProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionProductos.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionProductos.Location = new System.Drawing.Point(332, 239);
            this.txtDescripcionProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcionProductos.Multiline = true;
            this.txtDescripcionProductos.Name = "txtDescripcionProductos";
            this.txtDescripcionProductos.Size = new System.Drawing.Size(241, 98);
            this.txtDescripcionProductos.TabIndex = 89;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.BackColor = System.Drawing.Color.White;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(157, 280);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(169, 23);
            this.lblDescripcionProducto.TabIndex = 88;
            this.lblDescripcionProducto.Text = "Descripcion Producto";
            this.lblDescripcionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClaseNumero
            // 
            this.txtClaseNumero.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtClaseNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaseNumero.ForeColor = System.Drawing.Color.Black;
            this.txtClaseNumero.Location = new System.Drawing.Point(332, 209);
            this.txtClaseNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClaseNumero.Name = "txtClaseNumero";
            this.txtClaseNumero.Size = new System.Drawing.Size(241, 22);
            this.txtClaseNumero.TabIndex = 87;
            this.txtClaseNumero.TextChanged += new System.EventHandler(this.txtClaseNumero_TextChanged_1);
            // 
            // lblTipoMarca
            // 
            this.lblTipoMarca.AutoSize = true;
            this.lblTipoMarca.BackColor = System.Drawing.Color.White;
            this.lblTipoMarca.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMarca.Location = new System.Drawing.Point(239, 209);
            this.lblTipoMarca.Name = "lblTipoMarca";
            this.lblTipoMarca.Size = new System.Drawing.Size(87, 23);
            this.lblTipoMarca.TabIndex = 86;
            this.lblTipoMarca.Text = "Clase Niza";
            this.lblTipoMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvClasificacion
            // 
            this.dgvClasificacion.AllowUserToAddRows = false;
            this.dgvClasificacion.AllowUserToDeleteRows = false;
            this.dgvClasificacion.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvClasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClaseNumero,
            this.colDescripcion});
            this.dgvClasificacion.GridColor = System.Drawing.Color.LightPink;
            this.dgvClasificacion.Location = new System.Drawing.Point(216, 499);
            this.dgvClasificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvClasificacion.MultiSelect = false;
            this.dgvClasificacion.Name = "dgvClasificacion";
            this.dgvClasificacion.ReadOnly = true;
            this.dgvClasificacion.RowHeadersWidth = 51;
            this.dgvClasificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasificacion.Size = new System.Drawing.Size(310, 225);
            this.dgvClasificacion.TabIndex = 85;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(208, 400);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 84;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(315, 443);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 83;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(421, 400);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 35);
            this.btnModificar.TabIndex = 82;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(315, 400);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAgregar.TabIndex = 81;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(137, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(475, 351);
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 47);
            this.label2.TabIndex = 79;
            this.label2.Text = "(CopyWrite) © ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 59);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // colClaseNumero
            // 
            this.colClaseNumero.HeaderText = "Clase Niza";
            this.colClaseNumero.MinimumWidth = 6;
            this.colClaseNumero.Name = "colClaseNumero";
            this.colClaseNumero.ReadOnly = true;
            this.colClaseNumero.Width = 125;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Productos / Servicios";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 125;
            // 
            // FormClasificacion21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 750);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcionProductos);
            this.Controls.Add(this.lblDescripcionProducto);
            this.Controls.Add(this.txtClaseNumero);
            this.Controls.Add(this.lblTipoMarca);
            this.Controls.Add(this.dgvClasificacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormClasificacion21";
            this.Text = "FormClasificacion21";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcionProductos;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.TextBox txtClaseNumero;
        private System.Windows.Forms.Label lblTipoMarca;
        private System.Windows.Forms.DataGridView dgvClasificacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaseNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
    }
}