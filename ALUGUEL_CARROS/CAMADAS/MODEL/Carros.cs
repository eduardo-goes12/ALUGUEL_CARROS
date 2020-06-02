using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUGUEL_CARROS.CAMADAS.MODEL
{
    public class Carros
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string chassi { get; set; }
        public int ano { get; set; }
        public string placa { get; set; }
        public int situacao { get; set; }
    }
}
