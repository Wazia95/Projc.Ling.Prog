using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using e_commerce.Repositorios;
using e_commerce.Repositorios__DAL_;

namespace e_commerce.Formularios
{
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int encomendaId = int.Parse(txtIdEncomenda.Text);
            string motivo = txtMotivo.Text;
            decimal valor = decimal.Parse(txtValor.Text);

            DevolucaoRepository repo = new DevolucaoRepository();
            repo.CriarDevolucao(encomendaId, motivo, valor);

            MessageBox.Show("Devolução registada!");
        }

        private void pbFechra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
