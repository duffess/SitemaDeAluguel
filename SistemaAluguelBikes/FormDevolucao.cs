using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoAluguelBicicletas.Models;

namespace SistemaAluguelBikes
{
    public partial class FormDevolucao : Form
    {
        List<Aluguel> alugueis = new List<Aluguel>();

        public FormDevolucao()
        {
            InitializeComponent();
            CarregarAlugueis();
        }

        private void CarregarAlugueis()
        {
            alugueis.Add(new Aluguel { IdAluguel = 1, Cliente = new Cliente { Nome = "João" }, DataInicio = DateTime.Now.AddDays(-3) });
            cmbAluguel.Items.AddRange(alugueis.ToArray());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = cmbAluguel.SelectedItem as Aluguel;
            if (aluguel == null)
            {
                MessageBox.Show("Selecione um aluguel válido.");
                return;
            }


            Devolucao devolucao = new Devolucao
            {
                Aluguel = aluguel,
                DataDevolucao = dtpDevolucao.Value,
                Multa = decimal.Parse(txtMulta.Text)
            };

            MessageBox.Show("Devolução registrada com sucesso!");
            this.Close();
        }
    }
}
