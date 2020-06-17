using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ALUGUEL_CARROS.CAMADAS.BLL
{
    public class Clientes
    {
        public List<MODEL.Clientes> Select()
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            //regras de negocios


            //fim das regras
            return dalCliente.Select();
        }
        public List<MODEL.Clientes> SelectById(int id)
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            //regras de negocios


            //fim das regras
            return dalCliente.SelectbyId(id);
        }
        public List<MODEL.Clientes> SelectByNome(string nome)
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            //regras de negocios


            //fim das regras
            return dalCliente.SelectByNome(nome);
        }

        public List<MODEL.Clientes> SelectByCPF(string cpf)
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            //regras de negocios


            //fim das regras
            return dalCliente.SelectByCPF(cpf);
        }



        public void Insert(MODEL.Clientes cliente)
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            //regras de negocios



            //fim das regras
            dalCliente.Insert(cliente);

        }
        public void Update(MODEL.Clientes cliente)
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            //regras de negocios


            //fim das regras
            dalCliente.Update(cliente);

        }
        public void Delete(int idCliente)
        {
            DAL.Clientes dalCliente = new DAL.Clientes();
            //regras de negocios


            //fim das regras
            dalCliente.Delete(idCliente);
        }
    }
}
