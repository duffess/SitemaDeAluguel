namespace SistemaAluguelBikes
{
    partial class FormDevolucao
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
            this.cmbAluguel = new System.Windows.Forms.ComboBox();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAluguel
            // 
            this.cmbAluguel.FormattingEnabled = true;
            this.cmbAluguel.Location = new System.Drawing.Point(279, 42);
            this.cmbAluguel.Name = "cmbAluguel";
            this.cmbAluguel.Size = new System.Drawing.Size(215, 21);
            this.cmbAluguel.TabIndex = 0;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Location = new System.Drawing.Point(278, 85);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(215, 20);
            this.dtpDevolucao.TabIndex = 1;
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(278, 129);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(215, 20);
            this.txtMulta.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.cmbAluguel);
            this.Name = "FormDevolucao";
            this.Text = "FormDevolucao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAluguel;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Button button1;
    }
}