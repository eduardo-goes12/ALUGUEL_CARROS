using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUGUEL_CARROS.CAMADAS.BLL
{
    public class Carros
    {
        public List<MODEL.Carros> Select()
        {
            DAL.Carros dalCarro = new DAL.Carros();
            //regras de negocios


            //fim das regras
            return dalCarro.Select();
        }

        public void Insert(MODEL.Carros carro)
        {
            DAL.Carros dalCarro = new DAL.Carros();
            //regras de negocios



            //fim das regras
            dalCarro.Insert(carro);

        }
        public void Update(MODEL.Carros carro)
        {
            DAL.Carros dalcarro = new DAL.Carros();
            //regras de negocios


            //fim das regras
            dalcarro.Update(carro);

        }
        public void Delete(int idCarro)
        {
            DAL.Carros dalCarro = new DAL.Carros();
            //regras de negocios


            //fim das regras
            dalCarro.Delete(idCarro);
        }
    }
}
