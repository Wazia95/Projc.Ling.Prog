namespace e_commerce.Formularios
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            panelControladora = new Panel();
            pbFechra = new PictureBox();
            pbFechar = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtTelefone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtEndereco = new TextBox();
            label7 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnRemover = new Button();
            groupBox1 = new GroupBox();
            dtpDataCadastro = new DateTimePicker();
            dgvClientes = new DataGridView();
            txtPesquisar = new TextBox();
            label9 = new Label();
            panelControladora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFechra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFechar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            pbFechra.TabIndex = 18;
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
            label1.Size = new Size(97, 36);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 572);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 15;
            label8.Text = "label8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 45);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 8;
            label2.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(6, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(98, 27);
            txtId.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 133);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(314, 27);
            txtNome.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 11;
            label3.Text = "Nome:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 27);
            txtEmail.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 176);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 13;
            label4.Text = "E-mail:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(10, 271);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(129, 27);
            txtTelefone.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 248);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 15;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 248);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 16;
            label6.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(145, 271);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(175, 63);
            txtEndereco.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 326);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 19;
            label7.Text = "Deta Registo:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(8, 405);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 42);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(114, 405);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 42);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(220, 405);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 42);
            btnRemover.TabIndex = 22;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDataCadastro);
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(748, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 478);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Produtos";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Location = new Point(10, 349);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(310, 27);
            dtpDataCadastro.TabIndex = 23;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 101);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(730, 468);
            dgvClientes.TabIndex = 14;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(345, 68);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(397, 27);
            txtPesquisar.TabIndex = 16;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 71);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 17;
            label9.Text = "Pesquisar: ";
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 596);
            Controls.Add(label9);
            Controls.Add(txtPesquisar);
            Controls.Add(label8);
            Controls.Add(dgvClientes);
            Controls.Add(groupBox1);
            Controls.Add(panelControladora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCliente";
            Load += frmCliente_Load;
            panelControladora.ResumeLayout(false);
            panelControladora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFechra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFechar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelControladora;
        private PictureBox pbFechar;
        private Label label1;
        private Label label8;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtTelefone;
        private Label label5;
        private Label label6;
        private TextBox txtEndereco;
        private Label label7;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnRemover;
        private GroupBox groupBox1;
        private DateTimePicker dtpDataCadastro;
        private DataGridView dgvClientes;
        private TextBox txtPesquisar;
        private Label label9;
        private PictureBox pbFechra;
    }
}