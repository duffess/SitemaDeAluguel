using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAluguelBikes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aluguel de bicicletas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Devolução de Bicicletas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Emitir recibo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(945, 459);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        private string usuarioLogado;

        public MainForm(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            this.Text = $"Sistema de Aluguel - Usuário: {usuario}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAluguel formAluguel = new FormAluguel();
            formAluguel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDevolucao formDevolucao = new FormDevolucao();
            formDevolucao.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            FormRecibo formRecibo = new FormRecibo();
            formRecibo.ShowDialog();
        }
    }
}
