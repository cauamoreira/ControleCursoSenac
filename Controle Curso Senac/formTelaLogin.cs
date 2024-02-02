using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Curso_Senac
{
    public partial class formTelaLogin : Form
    {

        // determinar se a senha está visível ou oculta
        private bool _podeVerSenha = false;
        public formTelaLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            picLoading.Hide();
        }

        private void AbrirFormPrincipal()
        {
            AgendaCurso agenda_De_Curso = new AgendaCurso();
            agenda_De_Curso.Show();
            this.Hide();
        }

        private void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            picLoading.Show();
            await Task.Delay(1000);
            picLoading.Hide();

            using (var bd = new BancoDeDados())
            {
                // Se não houver usuários, cria um usuário administrador padrão
                if (!bd.Usuarios.Any())
                {
                    bd.Usuarios.Add(new Usuario
                    {
                        Login = "admin",
                        Senha = "senha1",
                        Cpf = "00000000000",
                        DataNascimento = DateTime.Now,
                        Ativo = true,
                        Administrador = true
                    });

                    bd.SaveChanges();
                }
                // Verifica se as credenciais do usuário inseridas são válidas
                var usuarioExistente = bd.Usuarios.FirstOrDefault(u => u.Login == usuario);

                if (usuarioExistente != null && Autenticacao.AutenticarUsuario(usuario, senha))
                {
                    MessageBox.Show($"Bem-vindo: {usuarioExistente.Login}", "Senac", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Historicos.Add(new Historico
                    {
                        Login = usuario,
                        DataHora = DateTime.Now,
                        Alteracao = $"Usuário {usuarioExistente.Login} fez login",
                        Detalhes = ""
                    });

                    bd.SaveChanges();

                    AbrirFormPrincipal();

                     formControleAcesso controleAcesso = Application.OpenForms.OfType<formControleAcesso>().FirstOrDefault();

                      if (controleAcesso != null)
                     {
                       controleAcesso.CarregarHistorico();
                      }
                }
                else
                {
                    MessageBox.Show("Falha no login. Verifique suas credenciais.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimparCampos();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            formEsqueceuSenha formEsqueceuSenha = new formEsqueceuSenha();
            formEsqueceuSenha.Show();
            this.Hide();
        }

        private async void picSenha_Click(object sender, EventArgs e)
        {
            _podeVerSenha = !_podeVerSenha;

            if (_podeVerSenha)
            {
                picSenha.Image = Properties.Resources.visualizar;
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                picSenha.Image = Properties.Resources.esconder;
                txtSenha.PasswordChar = '•';


                await Task.Delay(1000);


                if (_podeVerSenha)
                    return;


                txtSenha.PasswordChar = '•';
            }
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult iSair = MessageBox.Show("Deseja fechar o programa?",
                                                    "Agenda de Cursos",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (iSair == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {

                    Application.Exit();

                }
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnEntrar_Click(this, new EventArgs());
            }
        }

        private void TelaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
    
