using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALUGUEL_CARROS.CAMADAS.MODEL;
using ALUGUEL_CARROS.CAMADAS.Relatorios;

namespace ALUGUEL_CARROS.CAMADAS.Relatorios
{
    class RelatorioClientes
    {
        public static void relClientes () { 

        CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
        List<CAMADAS.MODEL.Clientes> lstClientes = new List<CAMADAS.MODEL.Clientes>();
        lstClientes = bllClientes.Select();

            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\ReClientes_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".html";


            StreamWriter ws = new StreamWriter(arquivo);
            using (ws)
            {
                ws.WriteLine("<html>");
                ws.WriteLine("<head>");
                ws.WriteLine("<meta http-equiv='Content-Type' " +
                            "content='text/html; charset=utf-8'/>");
                ws.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");

                ws.WriteLine("</head>");

                ws.WriteLine("<body>");
                ws.WriteLine("<h1>Relatório de Clientes</h1>");
                ws.WriteLine("<hr align='left' border:'5px' />");

                ws.WriteLine("<table class='table table-striped'>");
                //Cabeçalho da tabela

                ws.WriteLine("<tr align='right'>");
                ws.WriteLine("<th align='right' width='30px'>");
                ws.WriteLine("ID");
                ws.WriteLine("</th>");
                ws.WriteLine("<th align='right' width='250px'>");
                ws.WriteLine("NOME");
                ws.WriteLine("</th>");
                ws.WriteLine("<th align='right' width='150px'>");
                ws.WriteLine("CPF");
                ws.WriteLine("</th>");
                ws.WriteLine("<th  align='right' width='150px'>");
                ws.WriteLine("SEXO");
                ws.WriteLine("</th>");
                ws.WriteLine("</tr>");


                int cont = 0;
                float soma = 0;
                foreach (CAMADAS.MODEL.Clientes Clientes in lstClientes.OrderBy(o => o.id).ThenBy(t => t.id).ThenBy(w => w.nome))
                {

                    ws.WriteLine("<tr>");
                    ws.WriteLine("<td align='right' width='30px'>");
                    ws.WriteLine(Clientes.id);
                    ws.WriteLine("</td>");
                    ws.WriteLine("<td align='right' width='250px'>");
                    ws.WriteLine(Clientes.nome);
                    ws.WriteLine("</td>");
                    ws.WriteLine("<td align='right' width='150px'>");
                    ws.WriteLine(Clientes.cpf);
                    ws.WriteLine("</td>");
                    ws.WriteLine("<td  align='right' width='150px'>");
                    ws.WriteLine(Clientes.sexo);
                    ws.WriteLine("</td>");
                    cont++;
                }

                ws.WriteLine("");
                ws.WriteLine("");
                ws.WriteLine("</table>");
                ws.WriteLine("<hr align='left' border:'5px' />");
                ws.WriteLine("<h2>");
                ws.WriteLine("Total de Registros Impressos: " + cont.ToString());
                ws.WriteLine("</br>");
                ws.WriteLine("Total de clientes " + cont.ToString());
                ws.WriteLine("</body>");
                ws.WriteLine("</h2>");
                ws.WriteLine("</html>");
            }

        }
    }
}