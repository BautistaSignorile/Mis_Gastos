
namespace Mis_Gastos
{
    partial class frmGastos
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
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cboConcepto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(36, 77);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(53, 13);
            this.lblConcepto.TabIndex = 0;
            this.lblConcepto.Text = "Concepto";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(36, 121);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 1;
            this.lblImporte.Text = "Importe";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 45);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(134, 114);
            this.txtImporte.MaxLength = 10;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(99, 20);
            this.txtImporte.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(134, 39);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(158, 164);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cboConcepto
            // 
            this.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConcepto.FormattingEnabled = true;
            this.cboConcepto.Location = new System.Drawing.Point(134, 74);
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.Size = new System.Drawing.Size(99, 21);
            this.cboConcepto.TabIndex = 7;
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 199);
            this.Controls.Add(this.cboConcepto);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblConcepto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGastos";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.frmGastos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cboConcepto;
    }
}

