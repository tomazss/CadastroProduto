using MySql.Data.MySqlClient;
using System.Data;

namespace CadastroProduto
{
    public partial class FormProduto : Form
    {
        private Produto produto;
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            this.produto = new Produto();
            MySqlDataReader temp = this.produto.ListarProdutos();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dataGridProdutos.DataSource = dt;

        }

        public void AtualizarDataGrid()
        {
            MySqlDataReader temp = this.produto.ListarProdutos();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dataGridProdutos.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!textNome.Text.Equals(""))
                {
                    this.produto.Nome = textNome.Text;
                    this.produto.Id = textId.Text;
                    this.produto.CadastrarProduto();
                    textNome.Clear();

                    AtualizarDataGrid();

                }
                else
                {
                    MessageBox.Show("Erro digite o nome do  produto");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto" + ex.Message);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textId.Text.Equals(produto.Id)&& !textId.Text.Equals(""))
                {
                    this.produto.Id = textId.Text;
                    this.produto.ExcluirProduto();               
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("ERRO digite um (ID) válido");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO em excluir o produto" + ex.Message);

            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!textId.Text.Equals(produto.Id))
                {
                    if (!textNome.Text.Equals(""))
                    {
                        this.produto.Id = textId.Text;
                        this.produto.Nome = textNome.Text;
                        this.produto.AlterarProduto();
                        AtualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("ERRO digite o nome do produto");
                    }
                }
                else
                {
                    MessageBox.Show("ERRO esse (ID) não existe");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO em atualizar o produto" + ex.Message);
            }

        }


    }
}