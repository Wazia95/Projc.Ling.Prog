namespace e_commerce.Formularios
{
    partial class frmDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucao));
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtMotivo = new TextBox();
            txtValor = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txtIdEncomenda = new TextBox();
            btnDevolver = new Button();
            label8 = new Label();
            dgvDevolucao = new DataGridView();
            panelControladora = new Panel();
            pbFechar = new PictureBox();
            label1 = new Label();
            pbFechra = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucao).BeginInit();
            panelControladora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFechra).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMotivo);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtIdEncomenda);
            groupBox1.Controls.Add(btnDevolver);
            groupBox1.Location = new Point(766, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 478);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fazer Devolução";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 87);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 24;
            label3.Text = "Valor:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(6, 197);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(302, 86);
            txtMotivo.TabIndex = 28;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(178, 110);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(130, 27);
            txtValor.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 22;
            label2.Text = "ID da Encomenda:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 174);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 16;
            label6.Text = "Estado da Encomenda:";
            // 
            // txtIdEncomenda
            // 
            txtIdEncomenda.Location = new Point(6, 110);
            txtIdEncomenda.Name = "txtIdEncomenda";
            txtIdEncomenda.Size = new Size(166, 27);
            txtIdEncomenda.TabIndex = 21;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(6, 289);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(302, 44);
            btnDevolver.TabIndex = 20;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 572);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 26;
            label8.Text = "label8";
            // 
            // dgvDevolucao
            // 
            dgvDevolucao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevolucao.Location = new Point(12, 101);
            dgvDevolucao.Name = "dgvDevolucao";
            dgvDevolucao.RowHeadersWidth = 51;
            dgvDevolucao.Size = new Size(748, 468);
            dgvDevolucao.TabIndex = 25;
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
            panelControladora.TabIndex = 24;
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
            label1.Size = new Size(120, 36);
            label1.TabIndex = 0;
            label1.Text = "Devolução";
            // 
            // pbFechra
            // 
            pbFechra.Cursor = Cursors.Hand;
            pbFechra.Image = (Image)resources.GetObject("pbFechra.Image");
            pbFechra.Location = new Point(1056, 12);
            pbFechra.Name = "pbFechra";
            pbFechra.Size = new Size(24, 26);
            pbFechra.TabIndex = 28;
            pbFechra.TabStop = false;
            pbFechra.Click += pbFechra_Click;
            // 
            // frmDevolucao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 596);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(dgvDevolucao);
            Controls.Add(panelControladora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDevolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDevolucao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucao).EndInit();
            panelControladora.ResumeLayout(false);
            panelControladora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFechra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label6;
        private TextBox txtIdEncomenda;
        private ComboBox cbEstado;
        private Button btnDevolver;
        private Label label8;
        private DataGridView dgvDevolucao;
        private Panel panelControladora;
        private PictureBox pbFechar;
        private Label label1;
        private Label label3;
        private TextBox txtMotivo;
        private TextBox txtValor;
        private PictureBox pbFechra;
    }
}