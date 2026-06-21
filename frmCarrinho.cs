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
    public partial class frmCarrinho : Form
    {
        public frmCarrinho()
        {
            InitializeComponent();
        }

        private void CarregarCliente()
        {
            ClienteRepository cliente = new ClienteRepository();
            var lista = cliente.Listar();

            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!");
                return;
            }
            cbCliente.DataSource = lista;
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
        }

        private void CarregarProduto()
        {
            ProdutoRepository produto = new ProdutoRepository();
            var lista = produto.Listar();

            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado!");
                return;
            }
            cbProdutos.DataSource = lista;
            cbProdutos.DisplayMember = "Nome";
            cbProdutos.ValueMember = "Id";
        }

        private void frmCarrinho_Load(object sender, EventArgs e)
        {
            CarregarCliente();
            CarregarProduto();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int produtoId = (int)cbProdutos.SelectedValue;
            int qtd = (int)numQtd.Value;
            int clienteId = (int)cbCliente.SelectedValue;

            CarrinhoRepository carrinhoRepo = new CarrinhoRepository();
            int carrinhoId = carrinhoRepo.ObterCarrinhoPorCliente(clienteId);

            ItemCarrinhoRepository itemRepo = new ItemCarrinhoRepository();
            itemRepo.AdicionarItem(carrinhoId, produtoId, qtd);

            MessageBox.Show("Produto adicionado!");

            // ESSA LINHA É A QUE FALTAVA
            CarregarCarrinho();
        }

        private void dgvCarrinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCarrinho.CurrentRow.Cells["Id"].Value.ToString();
            cbProdutos.Text = dgvCarrinho.CurrentRow.Cells["Produto"].Value.ToString();
            numQtd.Text = dgvCarrinho.CurrentRow.Cells["Quantidade"].Value.ToString();
        }

        private void CarregarCarrinho()
        {
            int clienteId = (int)cbCliente.SelectedValue;

            CarrinhoRepository carrinhoRepo = new CarrinhoRepository();
            int carrinhoId = carrinhoRepo.ObterCarrinhoPorCliente(clienteId);

            ItemCarrinhoRepository itemRepo = new ItemCarrinhoRepository();
            dgvCarrinho.DataSource = itemRepo.Listar(carrinhoId);
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            int clienteId = (int)cbCliente.SelectedValue;

            CarrinhoRepository carrinhoRepo = new CarrinhoRepository();
            int carrinhoId = carrinhoRepo.ObterCarrinhoPorCliente(clienteId);

            EncomendaRepository encomendaRepo = new EncomendaRepository();
            encomendaRepo.CriarEncomenda(clienteId, carrinhoId);

            MessageBox.Show("Compra finalizada!");

            // 👇 ATUALIZA AUTOMATICAMENTE
            if (frmEncomendas != null)
            {
                frmEncomendas.CarregarEncomendas();
            }

            // limpar carrinho visual
            dgvCarrinho.DataSource = null;
        }

        private void pbFechra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmEncomenda frmEncomendas; // 👈 AQUI
    }
}

