﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadPadoca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verificar se a pessoa digitou o email e a senha: length ve quantos caracter tem
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("Digite um e-mail válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Digite uma senha válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir...
                Model.Usuario usuario = new Model.Usuario();

                // Colocar os valores dos campos nos atributos do usuário:
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;

                // Tabela que vai receber o resultado do SELECT (logar) criou uma variavel tipo tabela
                DataTable resultado = usuario.Logar();

                // Verificar se acertou o email e senha:
                if(resultado.Rows.Count == 0)
                {
                    MessageBox.Show("E-mail e/ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Armazenar as infos vindas do bd no objeto "usuario"
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    // Mudar para o menu principal:
                    MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                    Hide(); // Esconder janela atual
                    menuPrincipal.ShowDialog(); // Mostrar o menu principal

                    Show(); // Mostar a tela de login ao sair do menu principal
                }
            }
        }
    }
}
