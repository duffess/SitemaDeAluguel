using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoAluguelBicicletas.Models;
using SistemaAluguelBikes.DAO;

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
            ClienteDAO clienteDAO = new ClienteDAO();
            List<Cliente> clientes = clienteDAO.ListarClientes();

            cmbCliente.Items.Clear();

            foreach (var cliente in clientes)
            {
                cmbCliente.Items.Add(cliente);
            }


        }

        private void CarregarBicicletasDisponiveis()
        {
            BicicletaDAO bicicletaDAO = new BicicletaDAO();
            List<Bicicleta> bicicletas = bicicletaDAO.ListarBicicletasDisponiveis();

            chkBicicletas.Items.Clear();

            foreach (var bike in bicicletas)
            {
                chkBicicletas.Items.Add(bike);
            }
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
