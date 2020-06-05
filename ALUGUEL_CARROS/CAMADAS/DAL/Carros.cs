using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUGUEL_CARROS.CAMADAS.DAL
{
    public class Carros
    {
        private string strCon = Conexao.getConexao(); 

        //select Carros
        public List<MODEL.Carros> Select()
        {
            List<MODEL.Carros> lstCarros = new List<MODEL.Carros>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Carros;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //tratamento exceção
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {

                    MODEL.Carros carro = new MODEL.Carros();
                    carro.id = Convert.ToInt32(dados["id"].ToString());
                    carro.modelo = dados["modelo"].ToString();
                    carro.marca = dados["marca"].ToString();
                    carro.chassi = dados["chassi"].ToString();
                    carro.ano = Convert.ToInt32(dados["ano"].ToString());
                    carro.placa = dados["placa"].ToString();
                    carro.situacao = Convert.ToInt32(dados["situacao"].ToString());                   

                    lstCarros.Add(carro);

                }
            }
            catch
            {
                Console.WriteLine("Erro no Select Carros");
            }
            finally
            {
                conexao.Close();
            }
            return lstCarros;
        }
        //Insert Carros
        public void Insert(MODEL.Carros carro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Carros values(@modelo, @marca, @chassi, @ano, @placa, @situacao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //adicionando os parametros        
            cmd.Parameters.AddWithValue("@modelo", carro.modelo);
            cmd.Parameters.AddWithValue("@marca", carro.marca);
            cmd.Parameters.AddWithValue("@chassi", carro.chassi);
            cmd.Parameters.AddWithValue("@ano", carro.ano);
            cmd.Parameters.AddWithValue("@placa", carro.placa);
            cmd.Parameters.AddWithValue("@situacao", carro.situacao);       


            //tratamento exceção
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no insert de Carros (DAL-Carros.cs)");
            }
            finally
            {
                conexao.Close();
            }
        }

        //Update Carros
        public void Update(MODEL.Carros carro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update Carros set modelo=@modelo, marca=@marca, chassi=@chassi, ano=@ano, placa=@placa, situacao=@situacao ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //adicionando os parametros
            cmd.Parameters.AddWithValue("@id", carro.id);
            cmd.Parameters.AddWithValue("@modelo", carro.modelo);
            cmd.Parameters.AddWithValue("@marca", carro.marca);
            cmd.Parameters.AddWithValue("@chassi", carro.chassi);
            cmd.Parameters.AddWithValue("@ano", carro.ano);
            cmd.Parameters.AddWithValue("@placa", carro.placa);
            cmd.Parameters.AddWithValue("@situacao", carro.situacao);


            //tratamento exceção
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no Update de Carros (DAL-Carros.cs)");
            }
            finally
            {
                conexao.Close();
            }

        }
        //delete carros
        public void Delete (int idCarro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Carros where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCarro);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("erro delete carros (DAL-Carros.cs)");

            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
