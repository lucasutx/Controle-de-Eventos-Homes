using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Home_s_Pizzaria
{
    public class SubTotal
    {
        SqlCommand cmd = new SqlCommand();
        ConexaoBD cb = new ConexaoBD();
        object valor = 0;
        public double valorPai = 0;
        public String msg = "";


        public SubTotal(String mesIni, String mesFini)
        {

            try
            {
                cmd.CommandText = "Select sum(valorevento) from clientes where data_cadastro BETWEEN @mesIni and @mesFini ";
                cmd.Parameters.AddWithValue("@mesIni", mesIni);
                cmd.Parameters.AddWithValue("@mesFini", mesFini);

                cmd.Connection = cb.Conectar();

                // O ExecuteScalar já retorna o valor diretamente, sem necessidade de ExecuteNonQuery
                valor = cmd.ExecuteScalar();

                valorPai = Convert.ToDouble(valor);

                cb.Desconectar();

                msg = "Consulta realizada com sucesso";
            }
            catch (FormatException)
            {
                // Caso específico para erro de formato de dados
                MessageBox.Show("Erro no formato das datas. Certifique-se de usar o formato 'yyyy-MM-dd'.",
                                "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msg = "Erro de formato ao calcular o subtotal.";
            }
            catch (SqlException ex)
            {
                // Caso específico para erros no banco de dados
                MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}",
                                "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msg = "Erro no banco de dados ao calcular o subtotal.";
            }
            
            finally
            {
                // Garantir que a conexão será fechada em caso de erro
                if (cb != null)
                {
                    cb.Desconectar();
                }
            }


        }
    }
}
