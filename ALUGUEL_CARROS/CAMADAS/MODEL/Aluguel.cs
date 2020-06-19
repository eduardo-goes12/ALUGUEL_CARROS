using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALUGUEL_CARROS.CAMADAS.MODEL
{
    public class Aluguel
    {
        public int id { get; set; }
        public int clienteID { get; set; }
        public string nome { get; set; }        
        public int carroID { get; set; }
        public string modelo { get; set; }
        
        
       

    }
}
