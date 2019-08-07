using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace taralsa.Class
{
    class SabitDaraCls
    {
        private SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=kntrkullanici;Integrated Security=True");
        protected void sqlcontrol()
        {
            try { baglanti.Close(); }
            catch { }
        }
        public DataTable TabloyuGetir()
        {
            sqlcontrol();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,PlakaNo,TartımKg,DisTartim,CariUnvaniFirma,MalzemeAdi,BirimFiyatı,AciklamaNot,SevkYeri,OperatörAdi,SöferAdi from SabitDaraliArac", baglanti);
            DataTable table = new DataTable();
            adapter.Fill(table);
            baglanti.Close();
            return table;
        }
        public void SatiriSil(string ID)
        {
            sqlcontrol();
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("DELETE  SabitDarliArac where Id='" + ID + "'", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        public void SatirGunceleme(string ID, string PlakaNo, string TartımKg, string DisTartim, string CariUnvaniFirma, string MalzemeAdi, string BirimFiyatı,string AciklamaNot,string SevkYeri,string OperatörAdi,string SöferAdi)
        {
            sqlcontrol();
            baglanti.Open();
            SqlCommand command = new SqlCommand("UPDATE  SabitDarliArac set PlakaNo='" + PlakaNo + "',TartımKg='" + TartımKg + "',DisTartim='" + DisTartim + "',CariUnvaniFirma='" + CariUnvaniFirma + "',MalzemeAdi='" + MalzemeAdi + "',BirimFiyatı='" + BirimFiyatı + "',AciklamaNot='" + AciklamaNot + "',SevkYeri='" + SevkYeri + "',OperatörAdi='" + OperatörAdi + "',SöferAdi='" + SöferAdi + "' where Id='" + ID + "'", baglanti );
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        public void YeniSatirEkle(string PlakaNo, string TartımKg, string DisTartim, string CariUnvaniFirma, string MalzemeAdi, string BirimFiyatı, string AciklamaNot, string SevkYeri, string OperatörAdi, string SöferAdi)
        {
            sqlcontrol();
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("Insert into  SabitDarliArac (PlakaNo,TartımKg,DisTartim,CariUnvaniFirma,MalzemeAdi,BirimFiyatı,AciklamaNot,SevkYeri,OperatörAdi,SöferAdi) Values ('" + PlakaNo + "','" + TartımKg + "','" + DisTartim + "','" + CariUnvaniFirma + "','" + MalzemeAdi + "','" + BirimFiyatı + "','" + AciklamaNot + "','" + SevkYeri + "','" + OperatörAdi + "','" + SöferAdi + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
