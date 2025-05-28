namespace SistemaAluguelBikes
{
    partial class FormRecibo
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
            this.cmbDevolucao = new System.Windows.Forms.ComboBox();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDevolucao
            // 
            this.cmbDevolucao.FormattingEnabled = true;
            this.cmbDevolucao.Location = new System.Drawing.Point(312, 40);
            this.cmbDevolucao.Name = "cmbDevolucao";
            this.cmbDevolucao.Size = new System.Drawing.Size(182, 21);
            this.cmbDevolucao.TabIndex = 0;
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(312, 87);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(181, 20);
            this.txtRecibo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Emitir Recibo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.cmbDevolucao);
            this.Name = "FormRecibo";
            this.Text = "FormRecibo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDevolucao;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Button button1;
    }
}