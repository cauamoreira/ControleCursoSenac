﻿using Microsoft.EntityFrameworkCore;
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
    public partial class formNovaSenha : Form
    {
        private Usuario usuario;
        public formNovaSenha(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            // Verificar se as senhas digitadas são compatíveis
            if (txtNovaSenha.Text == txtConfirmarSenha.Text)
            {
                // Atualizar a senha do usuário no banco de dados
                usuario.Senha = txtConfirmarSenha.Text;

                if (usuario.Senha.Length < 6 || !usuario.Senha.Any(char.IsDigit) || !usuario.Senha.Any(char.IsLetter))
                {
                    MessageBox.Show("A senha deve ter pelo menos 6 caracteres, incluindo pelo menos um número e uma letra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var bd = new BancoDeDados())
                {
                    bd.Entry(usuario).State = EntityState.Modified;

                    // Registrar a alteração de senha no histórico
                    bd.Historicos.Add(new Historico
                    {
                        Login = usuario.Login,
                        DataHora = DateTime.Now,
                        Alteracao = "Alteração de Senha",
                        Detalhes = $"Senha alterada para o usuário: {usuario.Login}"

                    });

                    bd.SaveChanges();

                }

                MessageBox.Show("Senha alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("As senhas não são compatíveis.", "Confirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar?",
                               "Alerta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                AbrirTelaLogin();

            }
        }
        private void AbrirTelaLogin()
        {
            formTelaLogin telaLogin = new formTelaLogin();
            telaLogin.Show();
        }

        private void NovaSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbrirTelaLogin();
        }
    }
}
