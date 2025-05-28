using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoAluguelBicicletas.Models;

namespace SistemaAluguelBikes
{
    public partial class FormAluguel : Form
    {
        public FormAluguel()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarBicicletasDisponiveis();
        }

        private void CarregarClientes()
        {
            // Simulação
            cmbCliente.Items.Add(new Cliente { IdCliente = 1, Nome = "João Silva" });
            cmbCliente.Items.Add(new Cliente { IdCliente = 2, Nome = "Ana Souza" });
        }

        private void CarregarBicicletasDisponiveis()
        {
            // Simulação
            chkBicicletas.Items.Add(new Bicicleta { IdBicicleta = 101, Modelo = "Caloi Aro 26" });
            chkBicicletas.Items.Add(new Bicicleta { IdBicicleta = 102, Modelo = "Monark Aro 29" });
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            List<Bicicleta> selecionadas = new List<Bicicleta>();

            foreach (var item in chkBicicletas.CheckedItems)
                selecionadas.Add((Bicicleta)item);

            if (cliente == null || selecionadas.Count == 0)
            {
                MessageBox.Show("Selecione o cliente e pelo menos uma bicicleta.");
                return;
            }

            Aluguel aluguel = new Aluguel
            {
                Cliente = cliente,
                Bicicletas = selecionadas,
                DataInicio = dtpInicio.Value
            };

            MessageBox.Show("Aluguel registrado com sucesso!");
            this.Close();
        }
    }
}
