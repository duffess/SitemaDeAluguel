using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoAluguelBicicletas.Models;

namespace SistemaAluguelBikes
{
    public partial class FormRecibo : Form
    {
        List<Devolucao> devolucoes = new List<Devolucao>();

        public FormRecibo()
        {
            InitializeComponent();
            CarregarDevolucoes();
        }

        private void CarregarDevolucoes()
        {
            devolucoes.Add(new Devolucao
            {
                IdDevolucao = 1,
                Aluguel = new Aluguel
                {
                    Cliente = new Cliente { Nome = "João" },
                    DataInicio = DateTime.Now.AddDays(-3)
                },
                DataDevolucao = DateTime.Now,
                Multa = 30
            });

            cmbDevolucao.Items.AddRange(devolucoes.ToArray());
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Devolucao devolucao = cmbDevolucao.SelectedItem as Devolucao;
            if (devolucao == null)
            {
                MessageBox.Show("Selecione uma devolução válida.");
                return;
            }

            Recibo recibo = new Recibo
            {
                IdRecibo = 1,
                Aluguel = devolucao.Aluguel,
                Devolucao = devolucao,
                DataEmissao = DateTime.Now,
                Valor = devolucao.Multa
            };

            txtRecibo.Text = $"Recibo #{recibo.IdRecibo}\n" +
                             $"Cliente: {recibo.Aluguel.Cliente.Nome}\n" +
                             $"Data Emissão: {recibo.DataEmissao}\n" +
                             $"Valor: R$ {recibo.Valor}";
        }

    }
}
