using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ALUGUEL_CARROS.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {

                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = dados["cpf"].ToString();
                    cliente.sexo = dados["sexo"].ToString();

                    lstClientes.Add(cliente);
                    

                    //opa
                }
            }
            catch
            {
                Console.WriteLine("Erro no Select Clientes");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }
    }
}
