namespace Controle_Curso_Senac
{
    partial class formCadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroCurso));
            btnVoltarAgenda = new Button();
            btnExcluirCurso = new Button();
            btnAdicionarCurso = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnAlterarCurso = new Button();
            GridViewCadastroCurso = new DataGridView();
            pictureBox1 = new PictureBox();
            lblId = new Label();
            btnAlterar = new Button();
            btnAdicionar = new Button();
            txtId = new TextBox();
            btnSair = new Button();
            txtCadastroCurso = new TextBox();
            label = new Label();
            btnExcluir = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)GridViewCadastroCurso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltarAgenda
            // 
            btnVoltarAgenda.Anchor = AnchorStyles.Bottom;
            btnVoltarAgenda.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltarAgenda.Location = new Point(732, 848);
            btnVoltarAgenda.Margin = new Padding(3, 2, 3, 2);
            btnVoltarAgenda.Name = "btnVoltarAgenda";
            btnVoltarAgenda.Size = new Size(96, 30);
            btnVoltarAgenda.TabIndex = 9;
            btnVoltarAgenda.Text = "Sair";
            btnVoltarAgenda.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCurso
            // 
            btnExcluirCurso.Anchor = AnchorStyles.Bottom;
            btnExcluirCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluirCurso.Location = new Point(581, 848);
            btnExcluirCurso.Margin = new Padding(3, 2, 3, 2);
            btnExcluirCurso.Name = "btnExcluirCurso";
            btnExcluirCurso.Size = new Size(96, 30);
            btnExcluirCurso.TabIndex = 4;
            btnExcluirCurso.Text = "Excluir";
            btnExcluirCurso.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCurso
            // 
            btnAdicionarCurso.Anchor = AnchorStyles.Bottom;
            btnAdicionarCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarCurso.Location = new Point(293, 848);
            btnAdicionarCurso.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarCurso.Name = "btnAdicionarCurso";
            btnAdicionarCurso.Size = new Size(96, 30);
            btnAdicionarCurso.TabIndex = 2;
            btnAdicionarCurso.Text = "Adicionar";
            btnAdicionarCurso.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Curso";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 39;
            // 
            // btnAlterarCurso
            // 
            btnAlterarCurso.Anchor = AnchorStyles.Bottom;
            btnAlterarCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarCurso.Location = new Point(434, 848);
            btnAlterarCurso.Margin = new Padding(3, 2, 3, 2);
            btnAlterarCurso.Name = "btnAlterarCurso";
            btnAlterarCurso.Size = new Size(96, 30);
            btnAlterarCurso.TabIndex = 3;
            btnAlterarCurso.Text = "Alterar";
            btnAlterarCurso.UseVisualStyleBackColor = true;
            // 
            // GridViewCadastroCurso
            // 
            GridViewCadastroCurso.AllowUserToAddRows = false;
            GridViewCadastroCurso.AllowUserToDeleteRows = false;
            GridViewCadastroCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewCadastroCurso.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            GridViewCadastroCurso.Location = new Point(1, 213);
            GridViewCadastroCurso.Margin = new Padding(3, 4, 3, 4);
            GridViewCadastroCurso.Name = "GridViewCadastroCurso";
            GridViewCadastroCurso.ReadOnly = true;
            GridViewCadastroCurso.RowHeadersWidth = 51;
            GridViewCadastroCurso.RowTemplate.Height = 25;
            GridViewCadastroCurso.Size = new Size(682, 184);
            GridViewCadastroCurso.TabIndex = 0;
            GridViewCadastroCurso.CellClick += GridViewCadastroCurso_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(615, 194);
            lblId.Name = "lblId";
            lblId.Size = new Size(26, 18);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            lblId.Visible = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(196, 435);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(96, 30);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(29, 434);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 30);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.Location = new Point(649, 190);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(23, 23);
            txtId.TabIndex = 0;
            txtId.Visible = false;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(553, 434);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(96, 30);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtCadastroCurso
            // 
            txtCadastroCurso.BackColor = SystemColors.HighlightText;
            txtCadastroCurso.BorderStyle = BorderStyle.FixedSingle;
            txtCadastroCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCadastroCurso.Location = new Point(1, 187);
            txtCadastroCurso.Margin = new Padding(3, 4, 3, 4);
            txtCadastroCurso.Name = "txtCadastroCurso";
            txtCadastroCurso.Size = new Size(273, 25);
            txtCadastroCurso.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(1, 170);
            label.Name = "label";
            label.Size = new Size(117, 18);
            label.TabIndex = 0;
            label.Text = "Adicionar curso:";
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(371, 435);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 30);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnVoltarAgenda);
            panel1.Controls.Add(btnExcluirCurso);
            panel1.Controls.Add(btnAlterarCurso);
            panel1.Controls.Add(btnAdicionarCurso);
            panel1.Controls.Add(GridViewCadastroCurso);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(txtCadastroCurso);
            panel1.Controls.Add(label);
            panel1.Controls.Add(btnExcluir);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.Desktop;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.MaximumSize = new Size(2160, 1242);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 499);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // CadastroCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 499);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO DE CURSO";
            FormClosing += CadastroCurso_FormClosing;
            Load += CadastroCurso_Load;
            ((System.ComponentModel.ISupportInitialize)GridViewCadastroCurso).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarAgenda;
        private Button btnExcluirCurso;
        private Button btnAdicionarCurso;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnAlterarCurso;
        private DataGridView GridViewCadastroCurso;
        private PictureBox pictureBox1;
        private Label lblId;
        private Button btnAlterar;
        private Button btnAdicionar;
        private TextBox txtId;
        private Button btnSair;
        private TextBox txtCadastroCurso;
        private Label label;
        private Button btnExcluir;
        private Panel panel1;
    }
}