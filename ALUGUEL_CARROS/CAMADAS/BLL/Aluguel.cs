using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUGUEL_CARROS.CAMADAS.BLL
{
    public class Aluguel
    {
        public List<MODEL.Aluguel> Select()
        {
            DAL.Aluguel dalAlu = new DAL.Aluguel();
            return dalAlu.Select();

        }
        public MODEL.Aluguel BuscaCliente(int id)
        {
            DAL.Aluguel dalAluguel = new DAL.Aluguel();
            //regras de negocios


            //fim das regras
            return dalAluguel.BuscaCliente(id);
        }

        public MODEL.Aluguel BuscaCarro(int id)
        {
            DAL.Aluguel dalAluguel = new DAL.Aluguel();
            //regras de negocios


            //fim das regras
            return dalAluguel.BuscaCarro(id);
        }
        public void Insert(MODEL.Aluguel aluguel)
        {
            DAL.Aluguel dalAlu = new DAL.Aluguel();
            dalAlu.Insert(aluguel);

        }

        public void Update(MODEL.Aluguel aluguel)
        {
            DAL.Aluguel dalAlu = new DAL.Aluguel();
            dalAlu.Update(aluguel);
        }
        public void Delete(int idAluguel)
        {
            DAL.Aluguel dalAlu = new DAL.Aluguel();
            dalAlu.Delete(idAluguel);
        }
        


    }
}
