using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUGUEL_CARROS.CAMADAS.MODEL
{
    public class Aluguel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int id_carro { get; set; }
        public string modelo { get; set; }
        public string chassi { get; set; }
        public int ano { get; set; }
        public string placa { get; set; }

    }
}
