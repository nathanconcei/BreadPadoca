using System;
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
    public partial class FormComandas : Form
    {
        Model.Usuario usuario;
        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
      
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvComandas.DataSource = produto.Listar();
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada:
            int ls = dgvComandas.SelectedCells[0].RowIndex;

            // Colocar o ID do produto no campo de código:
            txbCodProduto.Text = dgvComandas.Rows[ls].Cells[0].Value.ToString();
            // Colocar o nome do produto no campo de infomações:
            txbNomeProduto.Text = dgvComandas.Rows[ls].Cells[1].Value.ToString();

        }

        private void btnInformacaoContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão vazios
            if (txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbCodProduto.Text.Length == 0)
            {
                MessageBox.Show("Informe o código do produto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Desativar o grbInfos:
                grbInformações.Enabled = false;
                // Desativar o grbLancamento
                grbLancamento.Enabled = false;
            }
        }

        private void btnLancamentoLancar_Click(object sender, EventArgs e)
        {
            // Verificar se a quantidade foi preenchida
            if (txbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Instanciar
                Model.OrdemComanda ordemcomanda = new Model.OrdemComanda();

                // Pegar informações
                ordemcomanda.IdFicha = int.Parse(txbComanda.Text);
                ordemcomanda.IdProduto = int.Parse(txbCodProduto.Text);
                ordemcomanda.Quantidade = int.Parse(txbQuantidade.Text);
                // Puxar o id responsavel:
                ordemcomanda.IdResp = usuario.Id;

                if(ordemcomanda.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao executar lançamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ResetarCampos()
        {

            // limpar campos de edição
            txbCodProduto.Clear();
            txbComanda.Clear();
            txbNomeProduto.Clear();
            txbQuantidade.Clear();
            // Resetar os groupboxes:
            grbInformações.Enabled = false;
            grbLancamento.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
