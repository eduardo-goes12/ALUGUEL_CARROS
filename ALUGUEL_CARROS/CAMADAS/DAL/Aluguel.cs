using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUGUEL_CARROS.CAMADAS.DAL
{
    public class Aluguel
    {
        private string strCon = Conexao.getConexao();
        //select Aluguel
        public List<MODEL.Aluguel> Select()
        {
            List<MODEL.Aluguel> lstAluguel = new List<MODEL.Aluguel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluguel;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //tratamento exceção
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {

                    CAMADAS.MODEL.Aluguel aluguel = new MODEL.Aluguel();
                    aluguel.id = Convert.ToInt32(dados["id"].ToString());
                    aluguel.clienteID = Convert.ToInt32(dados["clienteID"].ToString());
                    CAMADAS.DAL.Clientes dalCli = new Clientes();
                    CAMADAS.MODEL.Clientes cliente = dalCli.SelectbyIdAluguel(aluguel.clienteID);
                    aluguel.nome = cliente.nome;
                    aluguel.carroID = Convert.ToInt32(dados["carroID"].ToString());
                    CAMADAS.DAL.Carros dalCar = new Carros();
                    CAMADAS.MODEL.Carros carro = dalCar.SelectByIdAluguel(aluguel.carroID);
                    aluguel.modelo = carro.modelo;                

                                        
                    

                    lstAluguel.Add(aluguel);
                }
            }
            catch
            {
                Console.WriteLine("Erro no Select Aluguel");
            }
            finally
            {
                conexao.Close();
            }
            return lstAluguel;
        }

        //Insert Aluguel
        public void Insert(MODEL.Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Aluguel values(@clienteID, @nome, @carroID, @modelo);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //adicionando os parametros        
            cmd.Parameters.AddWithValue("@clienteID", aluguel.clienteID);
            cmd.Parameters.AddWithValue("@nome", aluguel.nome);            
            cmd.Parameters.AddWithValue("@carroID", aluguel.carroID);
            cmd.Parameters.AddWithValue("@modelo", aluguel.modelo);           
            


            //tratamento exceção
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no insert de Aluguel (DAL-Aluguel.cs)");
            }
            finally
            {
                conexao.Close();
            }
        }
        public MODEL.Aluguel BuscaCliente(int id)
        {
            MODEL.Aluguel aluguel = new MODEL.Aluguel();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluguel where clienteID = @id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            //tratamento exceção
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    aluguel.id = Convert.ToInt32(dados["id"].ToString());
                    aluguel.clienteID = Convert.ToInt32(dados["clienteID"].ToString());
                    aluguel.nome = dados["nome"].ToString();
                    aluguel.carroID = Convert.ToInt32(dados["carroID"].ToString());
                    aluguel.modelo = dados["modelo"].ToString();                    
                }
            }
            catch
            {
                Console.WriteLine("Erro no Select Clientes por Id");
            }
            finally
            {
                conexao.Close();
            }
            return aluguel;
        }
        public MODEL.Aluguel BuscaCarro(int id)
        {
            MODEL.Aluguel aluguel = new MODEL.Aluguel();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluguel where carroID = @id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            //tratamento exceção
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    aluguel.id = Convert.ToInt32(dados["id"].ToString());
                    aluguel.clienteID = Convert.ToInt32(dados["clienteID"].ToString());
                    aluguel.nome = dados["nome"].ToString();
                    aluguel.carroID = Convert.ToInt32(dados["carroID"].ToString());
                    aluguel.modelo = dados["modelo"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Erro no Select Clientes por Id");
            }
            finally
            {
                conexao.Close();
            }
            return aluguel;
        }

        //Update Carros
        public void Update(MODEL.Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update Aluguel set clienteID=@clienteID, nome=@nome,carroID=@carroID, modelo=@modelo ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //adicionando os parametros
            cmd.Parameters.AddWithValue("@clienteID", aluguel.clienteID);
            cmd.Parameters.AddWithValue("@nome", aluguel.nome);
            cmd.Parameters.AddWithValue("@carroID", aluguel.carroID);
            cmd.Parameters.AddWithValue("@modelo", aluguel.modelo);
            

            //tratamento exceção
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no Update de Aluguel (DAL-Aluguel.cs)");
            }
            finally
            {
                conexao.Close();
            }

        }
        //delete carros
        public void Delete(int idAluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Aluguel where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idAluguel);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("erro delete carros (DAL-Aluguel.cs)");

            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
