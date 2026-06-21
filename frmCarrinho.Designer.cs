namespace e_commerce.Formularios
{
    partial class frmCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarrinho));
            panelControladora = new Panel();
            pbFechra = new PictureBox();
            pbFechar = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            dgvCarrinho = new DataGridView();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            label3 = new Label();
            cbCliente = new ComboBox();
            label2 = new Label();
            numQtd = new NumericUpDown();
            btnFinalizarCompra = new Button();
            btnAdicionar = new Button();
            label7 = new Label();
            cbProdutos = new ComboBox();
            label6 = new Label();
            panelControladora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFechra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // panelControladora
            // 
            panelControladora.BackColor = SystemColors.Control;
            panelControladora.Controls.Add(pbFechra);
            panelControladora.Controls.Add(pbFechar);
            panelControladora.Controls.Add(label1);
            panelControladora.Dock = DockStyle.Top;
            panelControladora.Location = new Point(0, 0);
            panelControladora.Name = "panelControladora";
            panelControladora.Size = new Size(1092, 51);
            panelControladora.TabIndex = 7;
            // 
            // pbFechra
            // 
            pbFechra.Cursor = Cursors.Hand;
            pbFechra.Image = (Image)resources.GetObject("pbFechra.Image");
            pbFechra.Location = new Point(1056, 12);
            pbFechra.Name = "pbFechra";
            pbFechra.Size = new Size(24, 26);
            pbFechra.TabIndex = 12;
            pbFechra.TabStop = false;
            pbFechra.Click += pbFechra_Click;
            // 
            // pbFechar
            // 
            pbFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbFechar.Cursor = Cursors.Hand;
            pbFechar.Image = (Image)resources.GetObject("pbFechar.Image");
            pbFechar.Location = new Point(1945, 12);
            pbFechar.Name = "pbFechar";
            pbFechar.Size = new Size(27, 0);
            pbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pbFechar.TabIndex = 11;
            pbFechar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Barlow Condensed Medium", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(103, 36);
            label1.TabIndex = 0;
            label1.Text = "Carrinho";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 567);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToOrderColumns = true;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(12, 96);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.RowHeadersWidth = 51;
            dgvCarrinho.Size = new Size(730, 468);
            dgvCarrinho.TabIndex = 13;
            dgvCarrinho.CellClick += dgvCarrinho_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numQtd);
            groupBox1.Controls.Add(btnFinalizarCompra);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbProdutos);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(748, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 478);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adiconar ao Carrinho";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(6, 79);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 26;
            label3.Text = "ID:";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(6, 154);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(314, 28);
            cbCliente.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 131);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 24;
            label2.Text = "O Cliente:";
            // 
            // numQtd
            // 
            numQtd.Location = new Point(8, 311);
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(150, 27);
            numQtd.TabIndex = 23;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.Location = new Point(174, 371);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(146, 42);
            btnFinalizarCompra.TabIndex = 21;
            btnFinalizarCompra.Text = "Finalizar Compra";
            btnFinalizarCompra.UseVisualStyleBackColor = true;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(8, 371);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(160, 42);
            btnAdicionar.TabIndex = 20;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 288);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 19;
            label7.Text = "Quantidade:";
            // 
            // cbProdutos
            // 
            cbProdutos.FormattingEnabled = true;
            cbProdutos.Location = new Point(6, 235);
            cbProdutos.Name = "cbProdutos";
            cbProdutos.Size = new Size(314, 28);
            cbProdutos.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 212);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 16;
            label6.Text = "Escolher Produtos:";
            // 
            // frmCarrinho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 596);
            Controls.Add(label8);
            Controls.Add(dgvCarrinho);
            Controls.Add(groupBox1);
            Controls.Add(panelControladora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCarrinho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarrinho";
            Load += frmCarrinho_Load;
            panelControladora.ResumeLayout(false);
            panelControladora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFechra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelControladora;
        private PictureBox pbFechar;
        private Label label1;
        private Label label8;
        private DataGridView dgvCarrinho;
        private GroupBox groupBox1;
        private Button btnFinalizarCompra;
        private Button btnAdicionar;
        private Label label7;
        private ComboBox cbProdutos;
        private Label label6;
        private NumericUpDown numQtd;
        private ComboBox cbCliente;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private PictureBox pbFechra;
    }
}