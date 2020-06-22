using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALUGUEL_CARROS.CAMADAS;
using ALUGUEL_CARROS.CAMADAS.BLL;
using ALUGUEL_CARROS.CAMADAS.Relatorios;


namespace ALUGUEL_CARROS.CAMADAS.Relatorios
{
    public class RelatoriosGerais
    {
        public static void relProduto()
        {

            CAMADAS.BLL.Carros bllCarros = new CAMADAS.BLL.Carros();
            List<CAMADAS.MODEL.Carros> lstCarros = new List<CAMADAS.MODEL.Carros>();
            lstCarros = bllCarros.Select();

            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\ReCarros_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".html";

            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                            "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");

                sw.WriteLine("</head>");

                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Carros</h1>");
                sw.WriteLine("<hr align='left' border:'5px' />");

                sw.WriteLine("<table class='table table-striped'>");
                //Cabeçalho da tabela

                sw.WriteLine("<tr align='right'>");
                sw.WriteLine("<th align='right' width='30px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='250px'>");
                sw.WriteLine("MODELO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("MARCA");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("CHASSI");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("PLACA");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");


                int cont = 0;
                float soma = 0;
                foreach (CAMADAS.MODEL.Carros Carros in lstCarros.OrderBy(o => o.id).ThenBy(t => t.modelo).ThenBy(w => w.marca))
                {

                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='right' width='30px'>");
                    sw.WriteLine(Carros.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='250px'>");
                    sw.WriteLine(Carros.modelo);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(Carros.marca);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(Carros.chassi);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(Carros.placa);
                    sw.WriteLine("</td>");
                    cont++;
                }

                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<h2>");
                sw.WriteLine("Total de Registros Impressos: " + cont.ToString());
                sw.WriteLine("</br>");
                sw.WriteLine("Total de carros alugados" + cont.ToString());
                sw.WriteLine("</body>");
                sw.WriteLine("</h2>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);

            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.CustomWkHtmlArgs = "--dpi 300";
            htmlToPdf.GeneratePdfFromFile(arquivo, null, arquivoPDF);
        }




    }
}
    }
}
