namespace BTS_3k2_PAV.InterfacesDeUsuario.Reportes
{
    partial class BugsConFiltros
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
            this.GbFiltros = new System.Windows.Forms.GroupBox();
            this.RwBugs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbFiltros
            // 
            this.GbFiltros.Controls.Add(this.RwBugs);
            this.GbFiltros.Controls.Add(this.BtnConsultar);
            this.GbFiltros.Controls.Add(this.CbEstado);
            this.GbFiltros.Controls.Add(this.DtpFechaHasta);
            this.GbFiltros.Controls.Add(this.DtpFechaDesde);
            this.GbFiltros.Controls.Add(this.label3);
            this.GbFiltros.Controls.Add(this.label2);
            this.GbFiltros.Controls.Add(this.label1);
            this.GbFiltros.Location = new System.Drawing.Point(12, 12);
            this.GbFiltros.Name = "GbFiltros";
            this.GbFiltros.Size = new System.Drawing.Size(1011, 576);
            this.GbFiltros.TabIndex = 3;
            this.GbFiltros.TabStop = false;
            this.GbFiltros.Text = "Filtros";
            // 
            // RwBugs
            // 
            this.RwBugs.BackColor = System.Drawing.SystemColors.Window;
            this.RwBugs.LocalReport.ReportEmbeddedResource = "BTS_3k2_PAV.InterfacesDeUsuario.Reportes.BugsPorFiltros.rdlc";
            this.RwBugs.Location = new System.Drawing.Point(6, 115);
            this.RwBugs.Name = "RwBugs";
            this.RwBugs.ServerReport.BearerToken = null;
            this.RwBugs.Size = new System.Drawing.Size(999, 455);
            this.RwBugs.TabIndex = 15;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(658, 73);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(115, 24);
            this.BtnConsultar.TabIndex = 14;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CbEstado
            // 
            this.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(140, 70);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(229, 24);
            this.CbEstado.TabIndex = 9;
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaHasta.Location = new System.Drawing.Point(658, 35);
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.Size = new System.Drawing.Size(236, 22);
            this.DtpFechaHasta.TabIndex = 8;
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaDesde.Location = new System.Drawing.Point(140, 35);
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.Size = new System.Drawing.Size(229, 22);
            this.DtpFechaDesde.TabIndex = 7;
            this.DtpFechaDesde.Value = new System.DateTime(2015, 7, 15, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde:";
            // 
            // BugsConFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1029, 595);
            this.Controls.Add(this.GbFiltros);
            this.Name = "BugsConFiltros";
            this.Text = "BugsConFiltros";
            this.Load += new System.EventHandler(this.BugsConFiltros_Load);
            this.GbFiltros.ResumeLayout(false);
            this.GbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbFiltros;
        private Microsoft.Reporting.WinForms.ReportViewer RwBugs;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.DateTimePicker DtpFechaHasta;
        private System.Windows.Forms.DateTimePicker DtpFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}