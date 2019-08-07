using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taralsa.Class
{
    class Raporlar
    {
        /// <summary>
        /// Her hangi bir raporun dinamik olarak ReportViewer kontrolüne yüklenmesini sağlar
        /// </summary>
        /// <param name="reportFile">Rdlc dosyasının adresi</param>
        /// <param name="dataSourceName">Raporun veri kaynağı adi</param>
        /// <param name="datasourceValue">Raporun veri kaynağı</param>
        /// <returns>Raporun yüklendiği ReportViewer nesne ögesidir</returns>

        public static ReportViewer GetReport(string reportFile, string dataSourceName, object datasourceValue)
        {
            ReportViewer viewer = new ReportViewer();
            ReportDataSource rDataSource = new ReportDataSource(dataSourceName, datasourceValue);
            viewer.LocalReport.DataSources.Add(rDataSource);
            viewer.LocalReport.ReportPath = reportFile;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            viewer.RefreshReport();
            return viewer;
        }
    }
}
