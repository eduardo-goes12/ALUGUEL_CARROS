using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALUGUEL_CARROS.CAMADAS.Relatorios
{
    class Funcoes
    {
        public static string deretorioPasta()
        {
            string folder = @"c:\RELADS";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

    }
}
