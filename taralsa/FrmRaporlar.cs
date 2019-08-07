using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taralsa.Class;

namespace taralsa
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kntrkullaniciDataSet.CikisYapmayanArac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cikisYapmayanAracTableAdapter.Fill(this.kntrkullaniciDataSet.CikisYapmayanArac);
            // TODO: Bu kod satırı 'kntrkullaniciDataSet.SevkYeri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sevkYeriTableAdapter.Fill(this.kntrkullaniciDataSet.SevkYeri);
            // TODO: Bu kod satırı 'kntrkullaniciDataSet.MalzemeBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.malzemeBilgileriTableAdapter.Fill(this.kntrkullaniciDataSet.MalzemeBilgileri);
            // TODO: Bu kod satırı 'kntrkullaniciDataSet.CariUnvaniFirma' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cariUnvaniFirmaTableAdapter.Fill(this.kntrkullaniciDataSet.CariUnvaniFirma);
            // TODO: Bu kod satırı 'kntrkullaniciDataSet.SabitDaraliArac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sabitDaraliAracTableAdapter.Fill(this.kntrkullaniciDataSet.SabitDaraliArac);

            tabPage1.Controls.Add(Raporlar.GetReport(System.Environment.CurrentDirectory+"\\Report\\RprtDara.rdlc", "DataSetDarali", bsDara));
            tabPage2.Controls.Add(Raporlar.GetReport(System.Environment.CurrentDirectory + "\\Report\\RprtCari.rdlc", "DataSet2", bsCari));
            tabPage3.Controls.Add(Raporlar.GetReport(System.Environment.CurrentDirectory + "\\Report\\RprtCikis.rdlc", "DataSetCikis", bsCikis));
            tabPage4.Controls.Add(Raporlar.GetReport(System.Environment.CurrentDirectory + "\\Report\\RprtMalzeme.rdlc", "DataSetMalzeme", bsMalzeme));
            tabPage5.Controls.Add(Raporlar.GetReport(System.Environment.CurrentDirectory + "\\Report\\RprtSevk.rdlc", "DataSetSevk", bsSevk));
        }
    }
}
