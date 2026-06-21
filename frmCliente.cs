using e_commerce.Modelos;
using e_commerce.Repositorios;
using e_commerce.Repositorios__DAL_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using e_commerce.Formularios;

namespace e_commerce.Formularios
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void CarregarClientes()
        {
            ClienteRepository repo = new ClienteRepository();
            dgvClientes.DataSource = repo.Listar();
            dgvClientes.Columns["DataRegisto"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text
            };

            ClienteRepository repo = new ClienteRepository();
            repo.Adicionar(c);

            MessageBox.Show("Cliente salvo!");
            CarregarClientes();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
            txtNome.Text = dgvClientes.CurrentRow.Cells["Nome"].Value.ToString();
            txtEmail.Text = dgvClientes.CurrentRow.Cells["Email"].Value.ToString();
            txtTelefone.Text = dgvClientes.CurrentRow.Cells["Telefone"].Value.ToString();
            txtEndereco.Text = dgvClientes.CurrentRow.Cells["Endereco"].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text
            };

            ClienteRepository repo = new ClienteRepository();
            repo.Atualizar(c);

            MessageBox.Show("Cliente atualizado!");
            CarregarClientes();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            ClienteRepository repo = new ClienteRepository();
            repo.Remover(id);

            MessageBox.Show("Cliente removido!");
            CarregarClientes();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            ClienteRepository repo = new ClienteRepository();
            dgvClientes.DataSource = repo.Pesquisar(txtPesquisar.Text);
        }

        private void pbFechra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
