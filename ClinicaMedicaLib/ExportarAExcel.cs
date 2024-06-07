using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace ClinicaMedicaLib
{
    public class ExportarAExcel
    {
        private XLWorkbook wb;

        public ExportarAExcel() { 
            this.wb = new XLWorkbook();
        }

        public void ExportarListaAExcel( IEnumerable listaAExportar, string archivoAGuardar)
        {
            IXLWorksheet xLWorksheet = this.wb.AddWorksheet();
            xLWorksheet.Cell("A1").Value = "Exportando Listado";
            xLWorksheet.Cell("A2").InsertData(listaAExportar);
            wb.SaveAs(archivoAGuardar);
        }

    }
}
