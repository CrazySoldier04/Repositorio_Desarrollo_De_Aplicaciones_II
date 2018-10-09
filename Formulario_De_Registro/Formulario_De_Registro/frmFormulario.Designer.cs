namespace Formulario_De_Registro
{
    partial class frmFormulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.gbxFormulario = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxIngles = new System.Windows.Forms.GroupBox();
            this.lblPorcentajeEscrito = new System.Windows.Forms.Label();
            this.lblHabladoPorcentaje = new System.Windows.Forms.Label();
            this.lblEscrito = new System.Windows.Forms.Label();
            this.lblHablado = new System.Windows.Forms.Label();
            this.barraEscrito = new System.Windows.Forms.TrackBar();
            this.barraHablado = new System.Windows.Forms.TrackBar();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.gbxFormulario.SuspendLayout();
            this.gbxIngles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraHablado)).BeginInit();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlTitulo.Controls.Add(this.pbxCerrar);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(820, 33);
            this.pnlTitulo.TabIndex = 0;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.BackgroundImage = global::Formulario_De_Registro.Properties.Resources.Windows_Close_Program_22531;
            this.pbxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCerrar.Location = new System.Drawing.Point(785, 0);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(35, 33);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(322, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario de registro";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlContenido.Controls.Add(this.gbxFormulario);
            this.pnlContenido.Controls.Add(this.gbxDatos);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 33);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(820, 512);
            this.pnlContenido.TabIndex = 1;
            // 
            // gbxFormulario
            // 
            this.gbxFormulario.Controls.Add(this.btnCancelar);
            this.gbxFormulario.Controls.Add(this.btnAceptar);
            this.gbxFormulario.Controls.Add(this.gbxIngles);
            this.gbxFormulario.Controls.Add(this.txtMunicipio);
            this.gbxFormulario.Controls.Add(this.lblMunicipio);
            this.gbxFormulario.Controls.Add(this.txtEstado);
            this.gbxFormulario.Controls.Add(this.lblEstado);
            this.gbxFormulario.Controls.Add(this.txtNo);
            this.gbxFormulario.Controls.Add(this.lblNo);
            this.gbxFormulario.Controls.Add(this.txtDireccion);
            this.gbxFormulario.Controls.Add(this.lblDireccion);
            this.gbxFormulario.Controls.Add(this.dateTimePicker1);
            this.gbxFormulario.Controls.Add(this.lblFechaNacimiento);
            this.gbxFormulario.Controls.Add(this.txtApellidos);
            this.gbxFormulario.Controls.Add(this.txtNombre);
            this.gbxFormulario.Controls.Add(this.lblApellido);
            this.gbxFormulario.Controls.Add(this.lblNombre);
            this.gbxFormulario.Location = new System.Drawing.Point(413, 6);
            this.gbxFormulario.Name = "gbxFormulario";
            this.gbxFormulario.Size = new System.Drawing.Size(404, 494);
            this.gbxFormulario.TabIndex = 2;
            this.gbxFormulario.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(208, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(187, 36);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(6, 452);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(196, 36);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbxIngles
            // 
            this.gbxIngles.Controls.Add(this.lblPorcentajeEscrito);
            this.gbxIngles.Controls.Add(this.lblHabladoPorcentaje);
            this.gbxIngles.Controls.Add(this.lblEscrito);
            this.gbxIngles.Controls.Add(this.lblHablado);
            this.gbxIngles.Controls.Add(this.barraEscrito);
            this.gbxIngles.Controls.Add(this.barraHablado);
            this.gbxIngles.Location = new System.Drawing.Point(21, 289);
            this.gbxIngles.Name = "gbxIngles";
            this.gbxIngles.Size = new System.Drawing.Size(256, 157);
            this.gbxIngles.TabIndex = 15;
            this.gbxIngles.TabStop = false;
            this.gbxIngles.Text = "Nivel de Inglés";
            // 
            // lblPorcentajeEscrito
            // 
            this.lblPorcentajeEscrito.AutoSize = true;
            this.lblPorcentajeEscrito.Location = new System.Drawing.Point(199, 108);
            this.lblPorcentajeEscrito.Name = "lblPorcentajeEscrito";
            this.lblPorcentajeEscrito.Size = new System.Drawing.Size(35, 21);
            this.lblPorcentajeEscrito.TabIndex = 19;
            this.lblPorcentajeEscrito.Text = "0 %";
            // 
            // lblHabladoPorcentaje
            // 
            this.lblHabladoPorcentaje.AutoSize = true;
            this.lblHabladoPorcentaje.Location = new System.Drawing.Point(199, 47);
            this.lblHabladoPorcentaje.Name = "lblHabladoPorcentaje";
            this.lblHabladoPorcentaje.Size = new System.Drawing.Size(35, 21);
            this.lblHabladoPorcentaje.TabIndex = 18;
            this.lblHabladoPorcentaje.Text = "0 %";
            // 
            // lblEscrito
            // 
            this.lblEscrito.AutoSize = true;
            this.lblEscrito.Location = new System.Drawing.Point(6, 84);
            this.lblEscrito.Name = "lblEscrito";
            this.lblEscrito.Size = new System.Drawing.Size(60, 21);
            this.lblEscrito.TabIndex = 17;
            this.lblEscrito.Text = "Escrito";
            // 
            // lblHablado
            // 
            this.lblHablado.AutoSize = true;
            this.lblHablado.Location = new System.Drawing.Point(6, 23);
            this.lblHablado.Name = "lblHablado";
            this.lblHablado.Size = new System.Drawing.Size(78, 21);
            this.lblHablado.TabIndex = 16;
            this.lblHablado.Text = "Hablado";
            // 
            // barraEscrito
            // 
            this.barraEscrito.Location = new System.Drawing.Point(6, 108);
            this.barraEscrito.Maximum = 100;
            this.barraEscrito.Name = "barraEscrito";
            this.barraEscrito.Size = new System.Drawing.Size(188, 45);
            this.barraEscrito.TabIndex = 15;
            this.barraEscrito.TickFrequency = 5;
            this.barraEscrito.Scroll += new System.EventHandler(this.barraEscrito_Scroll);
            // 
            // barraHablado
            // 
            this.barraHablado.Location = new System.Drawing.Point(6, 47);
            this.barraHablado.Maximum = 100;
            this.barraHablado.Name = "barraHablado";
            this.barraHablado.Size = new System.Drawing.Size(188, 45);
            this.barraHablado.TabIndex = 14;
            this.barraHablado.TickFrequency = 5;
            this.barraHablado.Scroll += new System.EventHandler(this.barraHablado_Scroll);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(116, 256);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(142, 27);
            this.txtMunicipio.TabIndex = 13;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(17, 259);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(93, 21);
            this.lblMunicipio.TabIndex = 12;
            this.lblMunicipio.Text = "Municipio: ";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(116, 205);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(142, 27);
            this.txtEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(33, 208);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 21);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado: ";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(325, 157);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(73, 27);
            this.txtNo.TabIndex = 9;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(283, 160);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(36, 21);
            this.lblNo.TabIndex = 8;
            this.lblNo.Text = "No.";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 157);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(163, 27);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 160);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(91, 21);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(17, 117);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(185, 21);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(111, 66);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(287, 27);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(287, 27);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 21);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellidos: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre(s): ";
            // 
            // gbxDatos
            // 
            this.gbxDatos.BackColor = System.Drawing.SystemColors.Menu;
            this.gbxDatos.Controls.Add(this.dgvDatos);
            this.gbxDatos.Location = new System.Drawing.Point(12, 6);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(395, 494);
            this.gbxDatos.TabIndex = 1;
            this.gbxDatos.TabStop = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.GridColor = System.Drawing.Color.Black;
            this.dgvDatos.Location = new System.Drawing.Point(3, 23);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(389, 468);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 79;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de nacimiento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 165;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Domicilio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 85;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Municipio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 91;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 70;
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 545);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFormulario_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.gbxFormulario.ResumeLayout(false);
            this.gbxFormulario.PerformLayout();
            this.gbxIngles.ResumeLayout(false);
            this.gbxIngles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraHablado)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.GroupBox gbxFormulario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox gbxIngles;
        private System.Windows.Forms.Label lblPorcentajeEscrito;
        private System.Windows.Forms.Label lblHabladoPorcentaje;
        private System.Windows.Forms.Label lblEscrito;
        private System.Windows.Forms.Label lblHablado;
        private System.Windows.Forms.TrackBar barraEscrito;
        private System.Windows.Forms.TrackBar barraHablado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

