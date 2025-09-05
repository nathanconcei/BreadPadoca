using BreadPadoca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BreadPadoca
{
    public partial class FormProdutos : Form
    {
        Model.Produto produto = new Model.Produto();
        Model.Usuario usuario;

        int idSelecionado = 0;

        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ListarCategoriasCmb();

            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            // Mostrar as informações do banco de dados no datagridview:
            dgvProdutos.DataSource = produto.Listar();
        }

        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela para receber o resultado do SELECT:
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                // 1 - Salgados
                // 2 - Refrigerantes
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeCadastrar.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no minimo 2 caracteres.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbPrecoCadastro.Text.Length < 1)
            {
                MessageBox.Show("O preco deve ter no minimo 1 caracter.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbCategoriaCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("A categoria deve estar selecionada.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Fazer o cadastro
                Model.Produto produtoCadastro = new Model.Produto();

                // Salvar os valores dos campos nos atributos do obj:
                produtoCadastro.Nome = txbNomeCadastrar.Text;
                produtoCadastro.Preco = Convert.ToDouble(txbPrecoCadastro.Text);
                produtoCadastro.IdCategoria = Convert.ToInt32(cmbCategoriaCadastro.Text.Split('-')[0].Trim());
                produtoCadastro.IdRespCadastro = usuario.Id;

                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar o dgv:
                    AtualizarDgv();

                    // Apagar os campos de cadastro:
                    txbNomeCadastrar.Clear();
                    txbPrecoCadastro.Clear();
                    cmbCategoriaCadastro.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o produto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada:
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            // Colocar os valores das celulas nos txb de edição:
            txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();
            cmbCategoriaEditar.SelectedIndex = ls;

            // Armazenar o id de quem foi selecionado:
            idSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:
            grbEditar.Enabled = true;

            // Ajustes no grbApagar
            lblDescricaoApagar.Text = $"apagar: {txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString()}";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
        }

        public void ResetarCampos()
        {
            AtualizarDgv();

            // limpar campos de edição
            txbNomeEditar.Clear();
            txbPrecoEditar.Clear();
            cmbCategoriaEditar.SelectedIndex = -1;

            // Retornar o idSelecionado para 0
            idSelecionado = 0;

            // Retornar o texto padrão do "apagar":
            lblDescricaoApagar.Text = "Selecione o produto que deseja apagar.";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeEditar.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no mínimo 2 caracteres.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (!double.TryParse(txbPrecoEditar.Text, out double preco))
            {
                MessageBox.Show("Informe um preço válido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (cmbCategoriaEditar.SelectedIndex == -1)
            {
                MessageBox.Show("A categoria deve estar selecionada.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Model.Produto produtoEditar = new Model.Produto();
                produtoEditar.Id = idSelecionado;
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = preco;
                produtoEditar.IdCategoria = Convert.ToInt32(cmbCategoriaEditar.Text.Split('-')[0].Trim());

                // TERMINAR

                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Produto foi alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao alterar o produto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este produto?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Model.Produto produtoApagar = new Model.Produto();
                produtoApagar.Id = idSelecionado;

                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar o produto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
