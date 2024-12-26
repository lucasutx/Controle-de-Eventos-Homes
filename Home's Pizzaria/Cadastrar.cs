using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_s_Pizzaria
{
    public class Cadastrar
    {
        SqlCommand cmd = new SqlCommand();
        ConexaoBD cb = new ConexaoBD();

        public string msg = "";

        public Cadastrar(string nome, string endereco, string telefone, string email, double valor)
        {
            DateTime dataCadastro = DateTime.Now;
            cmd.CommandText = "INSERT INTO clientes (nome, endereco, telefone, email, valorEvento, data_cadastro) " +
                       "VALUES (@nome, @endereco, @telefone, @email, @valor, @data_cadastro)";

            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@data_cadastro",dataCadastro);

            try
            {
                cmd.Connection = cb.Conectar();

                cmd.ExecuteNonQuery();

                cb.Desconectar();

                this.msg = "Cadastrado com sucesso !";
            }
            catch (SqlException e)
            {
                this.msg = "Erro ao cadastrar ou na conexão";
            }

        }



    }
}
