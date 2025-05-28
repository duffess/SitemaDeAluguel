namespace SistemaAluguelBikes
{
    partial class FormAluguel
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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.chkBicicletas = new System.Windows.Forms.CheckedListBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(327, 52);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(181, 21);
            this.cmbCliente.TabIndex = 0;
            // 
            // chkBicicletas
            // 
            this.chkBicicletas.FormattingEnabled = true;
            this.chkBicicletas.Location = new System.Drawing.Point(327, 86);
            this.chkBicicletas.Name = "chkBicicletas";
            this.chkBicicletas.Size = new System.Drawing.Size(180, 34);
            this.chkBicicletas.TabIndex = 1;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(329, 140);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(177, 20);
            this.dtpInicio.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar Aluguel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.chkBicicletas);
            this.Controls.Add(this.cmbCliente);
            this.Name = "FormAluguel";
            this.Text = "FormAluguel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.CheckedListBox chkBicicletas;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button button1;
    }
}