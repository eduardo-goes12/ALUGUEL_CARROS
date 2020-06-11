using System;
using System.Collections.Generic;
using System.Linq;
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
