namespace BTS_3k2_PAV.InterfacesDeUsuario.Reportes.BugsPorEstado
{
    partial class FrmBugsPorEstado
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
            this.RwBugsSegunEstados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RwBugsSegunEstados
            // 
            this.RwBugsSegunEstados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RwBugsSegunEstados.LocalReport.ReportEmbeddedResource = "BTS_3k2_PAV.InterfacesDeUsuario.Reportes.BugsPorEstado.BugsPorEstado.rdlc";
            this.RwBugsSegunEstados.Location = new System.Drawing.Point(0, 0);
            this.RwBugsSegunEstados.Name = "RwBugsSegunEstados";
            this.RwBugsSegunEstados.ServerReport.BearerToken = null;
            this.RwBugsSegunEstados.Size = new System.Drawing.Size(800, 450);
            this.RwBugsSegunEstados.TabIndex = 0;
            this.RwBugsSegunEstados.ReportExport += new Microsoft.Reporting.WinForms.ExportEventHandler(this.RwBugsSegunEstados_ReportExport);
            // 
            // FrmBugsPorEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RwBugsSegunEstados);
            this.Name = "FrmBugsPorEstado";
            this.Text = "FrmBugsPorEstado";
            this.Load += new System.EventHandler(this.FrmBugsPorEstado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwBugsSegunEstados;
    }
}