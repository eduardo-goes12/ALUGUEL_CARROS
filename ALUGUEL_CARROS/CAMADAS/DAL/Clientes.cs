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

        //Select dados Clientes
        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //tratamento exceção
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

        //Insert dados Clientes

        public void Insert(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Clientes values(@nome, @cpf, @sexo);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //adicionando os parametros            
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@sexo", cliente.sexo);


            //tratamento exceção
            try
            {                
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no insert de clientes (DAL-Clientes.cs)");
            }
            finally
            {
                conexao.Close();
            }

        }

        //Update dados Clientes
        public void Update(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update Clientes set nome=@nome, cpf=@cpf, sexo=@sexo ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //adicionando os parametros
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@sexo", cliente.sexo);


            //tratamento exceção
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no Update de clientes (DAL-Clientes.cs)");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Clientes where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("erro delete clientes (DAL-Clientes.cs)");

            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
