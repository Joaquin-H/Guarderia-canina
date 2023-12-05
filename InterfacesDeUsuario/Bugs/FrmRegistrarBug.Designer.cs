namespace BTS_3k2_PAV.InterfacesDeUsuario.Bugs
{
    partial class FrmRegistrarBug
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.CBCriticidad = new System.Windows.Forms.ComboBox();
            this.CbPrioridad = new System.Windows.Forms.ComboBox();
            this.CbProducto = new System.Windows.Forms.ComboBox();
            this.TxtDecripcion = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(128, 249);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(86, 25);
            this.BtnGuardar.TabIndex = 43;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(264, 249);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(86, 25);
            this.BtnSalir.TabIndex = 42;
            this.BtnSalir.Text = "Cancelar";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // CBCriticidad
            // 
            this.CBCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCriticidad.FormattingEnabled = true;
            this.CBCriticidad.Location = new System.Drawing.Point(128, 209);
            this.CBCriticidad.Margin = new System.Windows.Forms.Padding(2);
            this.CBCriticidad.Name = "CBCriticidad";
            this.CBCriticidad.Size = new System.Drawing.Size(223, 21);
            this.CBCriticidad.TabIndex = 41;
            // 
            // CbPrioridad
            // 
            this.CbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPrioridad.FormattingEnabled = true;
            this.CbPrioridad.Location = new System.Drawing.Point(128, 170);
            this.CbPrioridad.Margin = new System.Windows.Forms.Padding(2);
            this.CbPrioridad.Name = "CbPrioridad";
            this.CbPrioridad.Size = new System.Drawing.Size(223, 21);
            this.CbPrioridad.TabIndex = 40;
            // 
            // CbProducto
            // 
            this.CbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProducto.FormattingEnabled = true;
            this.CbProducto.Location = new System.Drawing.Point(128, 128);
            this.CbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.CbProducto.Name = "CbProducto";
            this.CbProducto.Size = new System.Drawing.Size(223, 21);
            this.CbProducto.TabIndex = 39;
            // 
            // TxtDecripcion
            // 
            this.TxtDecripcion.Location = new System.Drawing.Point(128, 55);
            this.TxtDecripcion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDecripcion.Multiline = true;
            this.TxtDecripcion.Name = "TxtDecripcion";
            this.TxtDecripcion.Size = new System.Drawing.Size(223, 58);
            this.TxtDecripcion.TabIndex = 38;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(128, 15);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(223, 20);
            this.TxtTitulo.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Criticidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Prioridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Producto (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descripción (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Título (*)";
            // 
            // FrmRegistrarBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(368, 298);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.CBCriticidad);
            this.Controls.Add(this.CbPrioridad);
            this.Controls.Add(this.CbProducto);
            this.Controls.Add(this.TxtDecripcion);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistrarBug";
            this.Text = "Registrar Bug";
            this.Load += new System.EventHandler(this.FrmRegistrarBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox CBCriticidad;
        private System.Windows.Forms.ComboBox CbPrioridad;
        private System.Windows.Forms.ComboBox CbProducto;
        private System.Windows.Forms.TextBox TxtDecripcion;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}