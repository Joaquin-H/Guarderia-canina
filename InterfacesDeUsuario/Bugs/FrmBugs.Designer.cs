namespace BTS_3k2_PAV.InterfacesDeUsuario.Bugs
{
    partial class FrmBugs
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
            this.BtnPasarATesting = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnAsignar = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GbFiltros = new System.Windows.Forms.GroupBox();
            this.DgvBugs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Criticidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CbAsignadoA = new System.Windows.Forms.ComboBox();
            this.CbCriticidad = new System.Windows.Forms.ComboBox();
            this.CbProducto = new System.Windows.Forms.ComboBox();
            this.CbPrioridad = new System.Windows.Forms.ComboBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPasarATesting
            // 
            this.BtnPasarATesting.Location = new System.Drawing.Point(341, 504);
            this.BtnPasarATesting.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPasarATesting.Name = "BtnPasarATesting";
            this.BtnPasarATesting.Size = new System.Drawing.Size(92, 25);
            this.BtnPasarATesting.TabIndex = 34;
            this.BtnPasarATesting.Text = "Pasar a Testing";
            this.BtnPasarATesting.UseVisualStyleBackColor = true;
            // 
            // BtnVer
            // 
            this.BtnVer.Location = new System.Drawing.Point(274, 504);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(62, 25);
            this.BtnVer.TabIndex = 33;
            this.BtnVer.Text = "Ver";
            this.BtnVer.UseVisualStyleBackColor = true;
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.Location = new System.Drawing.Point(208, 504);
            this.BtnAsignar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(62, 25);
            this.BtnAsignar.TabIndex = 32;
            this.BtnAsignar.Text = "Asignar";
            this.BtnAsignar.UseVisualStyleBackColor = true;
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Location = new System.Drawing.Point(141, 504);
            this.BtnDarBaja.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(62, 25);
            this.BtnDarBaja.TabIndex = 31;
            this.BtnDarBaja.Text = "Dar Baja";
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(74, 504);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(62, 25);
            this.BtnModificar.TabIndex = 30;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(14, 504);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(56, 25);
            this.BtnNuevo.TabIndex = 29;
            this.BtnNuevo.Text = "Agregar";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(675, 504);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(86, 25);
            this.BtnSalir.TabIndex = 28;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GbFiltros
            // 
            this.GbFiltros.Controls.Add(this.DgvBugs);
            this.GbFiltros.Controls.Add(this.BtnConsultar);
            this.GbFiltros.Controls.Add(this.CbAsignadoA);
            this.GbFiltros.Controls.Add(this.CbCriticidad);
            this.GbFiltros.Controls.Add(this.CbProducto);
            this.GbFiltros.Controls.Add(this.CbPrioridad);
            this.GbFiltros.Controls.Add(this.CbEstado);
            this.GbFiltros.Controls.Add(this.DtpFechaHasta);
            this.GbFiltros.Controls.Add(this.DtpFechaDesde);
            this.GbFiltros.Controls.Add(this.label7);
            this.GbFiltros.Controls.Add(this.label6);
            this.GbFiltros.Controls.Add(this.label5);
            this.GbFiltros.Controls.Add(this.label4);
            this.GbFiltros.Controls.Add(this.label3);
            this.GbFiltros.Controls.Add(this.label2);
            this.GbFiltros.Controls.Add(this.label1);
            this.GbFiltros.Location = new System.Drawing.Point(7, 21);
            this.GbFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.GbFiltros.Name = "GbFiltros";
            this.GbFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.GbFiltros.Size = new System.Drawing.Size(758, 468);
            this.GbFiltros.TabIndex = 27;
            this.GbFiltros.TabStop = false;
            this.GbFiltros.Text = "Filtros";
            // 
            // DgvBugs
            // 
            this.DgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Producto,
            this.FechaCreacion,
            this.AsignadoA,
            this.Criticidad,
            this.Prioridad,
            this.Estado});
            this.DgvBugs.Location = new System.Drawing.Point(29, 184);
            this.DgvBugs.Margin = new System.Windows.Forms.Padding(2);
            this.DgvBugs.MultiSelect = false;
            this.DgvBugs.Name = "DgvBugs";
            this.DgvBugs.RowHeadersWidth = 51;
            this.DgvBugs.RowTemplate.Height = 24;
            this.DgvBugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBugs.Size = new System.Drawing.Size(724, 279);
            this.DgvBugs.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.HeaderText = "# Bug";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha de creacion";
            this.FechaCreacion.MinimumWidth = 6;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 125;
            // 
            // AsignadoA
            // 
            this.AsignadoA.HeaderText = "Asignado a";
            this.AsignadoA.MinimumWidth = 6;
            this.AsignadoA.Name = "AsignadoA";
            this.AsignadoA.ReadOnly = true;
            this.AsignadoA.Width = 125;
            // 
            // Criticidad
            // 
            this.Criticidad.HeaderText = "Criticidad";
            this.Criticidad.MinimumWidth = 6;
            this.Criticidad.Name = "Criticidad";
            this.Criticidad.ReadOnly = true;
            this.Criticidad.Width = 125;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.MinimumWidth = 6;
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            this.Prioridad.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(494, 127);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(86, 20);
            this.BtnConsultar.TabIndex = 14;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CbAsignadoA
            // 
            this.CbAsignadoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAsignadoA.FormattingEnabled = true;
            this.CbAsignadoA.Location = new System.Drawing.Point(494, 57);
            this.CbAsignadoA.Margin = new System.Windows.Forms.Padding(2);
            this.CbAsignadoA.Name = "CbAsignadoA";
            this.CbAsignadoA.Size = new System.Drawing.Size(178, 21);
            this.CbAsignadoA.TabIndex = 13;
            // 
            // CbCriticidad
            // 
            this.CbCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCriticidad.FormattingEnabled = true;
            this.CbCriticidad.Location = new System.Drawing.Point(494, 93);
            this.CbCriticidad.Margin = new System.Windows.Forms.Padding(2);
            this.CbCriticidad.Name = "CbCriticidad";
            this.CbCriticidad.Size = new System.Drawing.Size(178, 21);
            this.CbCriticidad.TabIndex = 12;
            // 
            // CbProducto
            // 
            this.CbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProducto.FormattingEnabled = true;
            this.CbProducto.Location = new System.Drawing.Point(105, 127);
            this.CbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.CbProducto.Name = "CbProducto";
            this.CbProducto.Size = new System.Drawing.Size(173, 21);
            this.CbProducto.TabIndex = 11;
            // 
            // CbPrioridad
            // 
            this.CbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPrioridad.FormattingEnabled = true;
            this.CbPrioridad.Location = new System.Drawing.Point(105, 93);
            this.CbPrioridad.Margin = new System.Windows.Forms.Padding(2);
            this.CbPrioridad.Name = "CbPrioridad";
            this.CbPrioridad.Size = new System.Drawing.Size(173, 21);
            this.CbPrioridad.TabIndex = 10;
            // 
            // CbEstado
            // 
            this.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(105, 57);
            this.CbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(173, 21);
            this.CbEstado.TabIndex = 9;
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaHasta.Location = new System.Drawing.Point(494, 28);
            this.DtpFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(178, 20);
            this.DtpFechaHasta.TabIndex = 8;
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.CustomFormat = "dd/MM/yy";
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaDesde.Location = new System.Drawing.Point(105, 28);
            this.DtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(173, 20);
            this.DtpFechaDesde.TabIndex = 7;
            this.DtpFechaDesde.Value = new System.DateTime(1753, 1, 1, 22, 46, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Asignado a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Criticidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prioridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde:";
            // 
            // FrmBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(772, 549);
            this.Controls.Add(this.BtnPasarATesting);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnAsignar);
            this.Controls.Add(this.BtnDarBaja);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GbFiltros);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBugs";
            this.Text = "Conuslta Bugs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBugs_FormClosing);
            this.Load += new System.EventHandler(this.FrmBugs_Load);
            this.GbFiltros.ResumeLayout(false);
            this.GbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPasarATesting;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnAsignar;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GbFiltros;
        private System.Windows.Forms.DataGridView DgvBugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignadoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criticidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CbAsignadoA;
        private System.Windows.Forms.ComboBox CbCriticidad;
        private System.Windows.Forms.ComboBox CbProducto;
        private System.Windows.Forms.ComboBox CbPrioridad;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}