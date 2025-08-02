using System.Linq;
using System.Windows;
using ClosedXML.Excel;
using AgenteMonitoreo.DataAccess;
using AgenteMonitoreo;

namespace AgenteMonitoreoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExportExcel_Click(object sender, RoutedEventArgs e)
        {
            using (var contexto = new ContextoSQL())
            {
                var datos = contexto.ControlDocumentosPorHora.ToList();
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Datos");
                    var propiedades = typeof(ControlDocumentosPorHora).GetProperties();

                    for (int col = 0; col < propiedades.Length; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = propiedades[col].Name;
                    }

                    int fila = 2;
                    foreach (var item in datos)
                    {
                        for (int col = 0; col < propiedades.Length; col++)
                        {
                            worksheet.Cell(fila, col + 1).Value = propiedades[col].GetValue(item);
                        }
                        fila++;
                    }

                    workbook.SaveAs("Exportacion.xlsx");
                }
            }

            MessageBox.Show("Datos exportados a Exportacion.xlsx");
        }
    }
}

