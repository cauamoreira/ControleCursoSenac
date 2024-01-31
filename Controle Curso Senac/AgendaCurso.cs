namespace Controle_Curso_Senac
{
    public partial class Agenda : Form

    {
        // Lista que armazena os dias selecionados na CheckBoxList
        private List<string> diasSelecionados = new List<string>();
        public Agenda()
        {

            InitializeComponent();

            clbDias.Items.AddRange(new object[]
      {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado"
      });
            clbDias.CheckOnClick = true;
        }

        private void iAdicionar()
        {

            if (CamposObrigatorios())
                return;

            // Obtém os valores dos campos do curso a ser adicionado
            var nome = cmbCurso.Text;
            var inicio = dtpInicio.Value;
            var fim = dtpFim.Value;
            var meta = txtMeta.Text;
            var horario = cmbHorario.Text;
            var realizado = txtRealizado.Text;
            var valor = mtbValor.Text;
            var turma = txtTurma.Text;
            var sala = txtSala.Text;

            using (var bd = new BancoDeDados())
            {
                // Verifica se já existe um curso com os mesmos detalhes
                if (CursoExistente(bd, turma, sala, horario, inicio))
                    return;

                // Obtém os dias selecionados na CheckBoxList
                diasSelecionados = clbDias.CheckedItems.OfType<string>().ToList();

                // Cria um novo curso e adiciona ao banco de dados
                var curso = new AgendaCurso()
                {
                    Nome = cmbCurso.Text,
                    Inicio = dtpInicio.Value.Date,
                    Fim = dtpFim.Value.Date,
                    Dias = string.Join(", ", diasSelecionados),
                    Horario = cmbHorario.Text,
                    Meta = txtMeta.Text,
                    Realizado = txtRealizado.Text,
                    Valor = mtbValor.Text,
                    Turma = txtTurma.Text,
                    Sala = txtSala.Text,
                };

                AdicionarHistorico(bd, nome);
                AdicionarCurso(bd, curso);

                LimparCheckBoxes();

                MessageBox.Show("Curso adicionado com sucesso.",
                    "Agenda de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPesquisar.Text = "";
                Listar();
                LimparCampos();
            }

        }


        private void LimparCampos()
        {
            txtId.Text = String.Empty;
            cmbCurso.Text = String.Empty; cmbCurso.SelectedIndex = -1;
            dtpInicio.Text = String.Empty;
            dtpFim.Text = String.Empty;
            clbDias.Text = String.Empty;
            cmbHorario.Text = String.Empty;
            txtMeta.Text = String.Empty;
            txtRealizado.Text = String.Empty;
            mtbValor.Text = String.Empty;
            txtTurma.Text = String.Empty;
            txtSala.Text = String.Empty;

            LimparCheckBoxes();

        }
        private void Listar()
        {
            gridCurso.Rows.Clear();

            using (var bd = new BancoDeDados())
            {
                var cursos = bd.AgendaCursos.ToList();


                foreach (var curso in cursos)
                {
                    gridCurso.Rows.Add(
                        curso.Id,
                        curso.Nome,
                        curso.Inicio,
                        curso.Fim,
                        curso.Dias,
                        curso.Horario,
                        curso.Meta,
                        curso.Realizado,
                        curso.Valor,
                        curso.Turma,
                        curso.Sala);
                }
            }
        }
        // Método para adicionar um registro de histórico de adição de curso
        private void AdicionarHistorico(BancoDeDados bd, string nome)
        {
            bd.Historicos.Add(new Historico
            {
                Login = Autenticacao.UsuarioAtual?.Login,
                DataHora = DateTime.Now,
                Alteracao = "Adição de Curso",
                Detalhes = $"Adicionado curso: {nome}"
            });
        }


        

        private bool CamposObrigatorios()
        {
            if (string.IsNullOrEmpty(cmbCurso.Text)
                || dtpInicio.Value == DateTime.MinValue
                || dtpFim.Value == DateTime.MinValue
                || dtpFim.Value.Date < dtpInicio.Value.Date
                || !clbDias.CheckedItems.OfType<object>().Any()
                || string.IsNullOrEmpty(cmbHorario.Text)
                || string.IsNullOrEmpty(txtMeta.Text)
                || string.IsNullOrEmpty(txtRealizado.Text)
                || string.IsNullOrWhiteSpace(mtbValor.Text)
                || string.IsNullOrEmpty(txtTurma.Text)
                || string.IsNullOrEmpty(txtSala.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        // Método para verificar se um curso com os mesmos detalhes já existe
        private bool CursoExistente(BancoDeDados bd, string turma, string sala, string horario, DateTime inicio)
        {
            var cursoExistente = bd.AgendaCursos
                .Any(c =>
                    c.Turma == turma &&
                    c.Sala == sala &&
                    c.Horario == horario &&
                    c.Inicio.Date == inicio.Date);

            if (cursoExistente)
            {
                MessageBox.Show("Já existe um curso na mesma turma, sala ou horário. Não é possível adicionar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void AdicionarCurso(BancoDeDados bd, AgendaCurso curso)
        {
            bd.AgendaCursos.Add(curso);
            bd.SaveChanges();
        }

        private void LimparCheckBoxes()
        {

            foreach (int index in clbDias.CheckedIndices)
            {
                clbDias.SetItemChecked(index, false);
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            iAdicionar();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                CadastroUsuario cadastroUsuario = new CadastroUsuario();
                cadastroUsuario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Você não tem acesso administrador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void acessoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
