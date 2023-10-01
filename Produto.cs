using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto
{
     class Produto
    {
        private string id;
        private string nome;
        private Banco banco;

        public Produto() 
        { 
          this.banco = new Banco();
        }

        public void CadastrarProduto()
        {
            this.banco.NonQuery($" insert into produtos (nome) values ('{Nome}')");
        }

        public void ExcluirProduto()
        {
            this.banco.NonQuery($" delete from produtos where  id = {Id}");
        }

        public void AlterarProduto()
        {
            this.banco.NonQuery($" UPDATE produtos SET `nome` = ('{Nome}') WHERE (`id` = {id});");
        }
        
        public MySqlDataReader ListarProdutos()
        {
         return this.banco.Query("Select * from produtos order by id asc ");
        }
        


        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
