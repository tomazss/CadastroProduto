using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CadastroProduto
{
   
     
      class Banco
    {
        //INFORMAÇÕES PARA CONEXÃO COM BANCO DE DADOS
        private const string servidor = "localhost"; 
        private const string bancoDados = "dbProdutos"; 
        private const string usuario = "root"; 
        private const string senha = "";
        private MySqlConnection con;
        private MySqlCommand command;

        public Banco()
        {
            Conectar();
        }
        public void Conectar()
        {
            string bancoServidor = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";
            this.con = new MySqlConnection(bancoServidor);
            this.command= this.con.CreateCommand();
            this.con.Open();


        }
        public void NonQuery(String sql)
        {
            this.command.CommandText = sql;
            this.command.ExecuteNonQuery();
        }
        public MySqlDataReader Query(String sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteReader();
        }


    }
}
