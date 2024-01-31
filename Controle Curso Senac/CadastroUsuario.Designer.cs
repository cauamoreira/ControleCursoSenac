namespace Controle_Curso_Senac
{
    partial class CadastroUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            GridConsultarUsuario = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dtpDataNascimento = new DateTimePicker();
            txtCpf = new TextBox();
            txtSenha = new TextBox();
            chkAdministrador = new CheckBox();
            label5 = new Label();
            label3 = new Label();
            chkAtivo = new CheckBox();
            txtId = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnVoltaAgenda = new Button();
            btnExcluir = new Button();
            btnAdicionarUsuario = new Button();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)GridConsultarUsuario).BeginInit();
            SuspendLayout();
            // 
            // GridConsultarUsuario
            // 
            GridConsultarUsuario.AllowUserToAddRows = false;
            GridConsultarUsuario.AllowUserToDeleteRows = false;
            GridConsultarUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridConsultarUsuario.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column6 });
            GridConsultarUsuario.GridColor = SystemColors.ActiveCaption;
            GridConsultarUsuario.Location = new Point(5, 168);
            GridConsultarUsuario.Margin = new Padding(3, 2, 3, 2);
            GridConsultarUsuario.Name = "GridConsultarUsuario";
            GridConsultarUsuario.ReadOnly = true;
            GridConsultarUsuario.RowHeadersWidth = 51;
            GridConsultarUsuario.RowTemplate.Height = 29;
            GridConsultarUsuario.ShowCellToolTips = false;
            GridConsultarUsuario.Size = new Size(781, 225);
            GridConsultarUsuario.StandardTab = true;
            GridConsultarUsuario.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 39;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Usuário";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "CPF";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            Column4.DefaultCellStyle = dataGridViewCellStyle9;
            Column4.HeaderText = "Data de Nascimento";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Senha";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Ativo";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Administrador";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Custom;
            dtpDataNascimento.Location = new Point(112, 110);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(232, 23);
            dtpDataNascimento.TabIndex = 27;
            dtpDataNascimento.Value = new DateTime(2024, 1, 13, 0, 0, 0, 0);
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.HighlightText;
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCpf.Location = new Point(413, 60);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(232, 25);
            txtCpf.TabIndex = 18;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.HighlightText;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.Location = new Point(413, 110);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(232, 25);
            txtSenha.TabIndex = 21;
            // 
            // chkAdministrador
            // 
            chkAdministrador.AutoSize = true;
            chkAdministrador.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkAdministrador.Location = new Point(198, 140);
            chkAdministrador.Margin = new Padding(3, 2, 3, 2);
            chkAdministrador.Name = "chkAdministrador";
            chkAdministrador.Size = new Size(124, 22);
            chkAdministrador.TabIndex = 23;
            chkAdministrador.Text = "Administrador";
            chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(413, 93);
            label5.Name = "label5";
            label5.Size = new Size(52, 18);
            label5.TabIndex = 24;
            label5.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(413, 43);
            label3.Name = "label3";
            label3.Size = new Size(37, 18);
            label3.TabIndex = 20;
            label3.Text = "CPF:";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkAtivo.Location = new Point(112, 140);
            chkAtivo.Margin = new Padding(3, 2, 3, 2);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(63, 22);
            chkAtivo.TabIndex = 25;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(116, 8);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(59, 25);
            txtId.TabIndex = 26;
            txtId.TextAlign = HorizontalAlignment.Center;
            txtId.Visible = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.HighlightText;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(112, 60);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(232, 25);
            txtUsuario.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 11);
            label1.Name = "label1";
            label1.Size = new Size(26, 18);
            label1.TabIndex = 17;
            label1.Text = "ID:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 43);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 19;
            label2.Text = "Usuário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(111, 93);
            label4.Name = "label4";
            label4.Size = new Size(147, 18);
            label4.TabIndex = 22;
            label4.Text = "Data de Nascimento:";
            // 
            // btnVoltaAgenda
            // 
            btnVoltaAgenda.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltaAgenda.Location = new Point(570, 417);
            btnVoltaAgenda.Margin = new Padding(3, 2, 3, 2);
            btnVoltaAgenda.Name = "btnVoltaAgenda";
            btnVoltaAgenda.Size = new Size(96, 30);
            btnVoltaAgenda.TabIndex = 31;
            btnVoltaAgenda.Text = "Sair";
            btnVoltaAgenda.UseVisualStyleBackColor = true;
            btnVoltaAgenda.Click += btnVoltaAgenda_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(410, 417);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 30);
            btnExcluir.TabIndex = 30;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarUsuario.Location = new Point(94, 417);
            btnAdicionarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(96, 30);
            btnAdicionarUsuario.TabIndex = 28;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.UseVisualStyleBackColor = true;
            btnAdicionarUsuario.Click += btnAdicionarUsuario_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(247, 417);
            btnAlterar.Margin = new Padding(3, 2, 3, 2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(96, 30);
            btnAlterar.TabIndex = 29;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(788, 476);
            Controls.Add(btnVoltaAgenda);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionarUsuario);
            Controls.Add(btnAlterar);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtSenha);
            Controls.Add(chkAdministrador);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(chkAtivo);
            Controls.Add(txtId);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(GridConsultarUsuario);
            Name = "CadastroUsuario";
            Text = "CadastroUsuario";
            ((System.ComponentModel.ISupportInitialize)GridConsultarUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridConsultarUsuario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DateTimePicker dtpDataNascimento;
        private TextBox txtCpf;
        private TextBox txtSenha;
        private CheckBox chkAdministrador;
        private Label label5;
        private Label label3;
        private CheckBox chkAtivo;
        private TextBox txtId;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnVoltaAgenda;
        private Button btnExcluir;
        private Button btnAdicionarUsuario;
        private Button btnAlterar;
    }
}