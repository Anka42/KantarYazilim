using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace taralsa.Class
{
    class CariUnvanCls
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=kntrkullanici;Integrated Security=True");
        protected void sqlcontrol()
        {
            try { conn.Close(); }
            catch { }
        }
        public DataTable TabloyuGetir()
        {
            sqlcontrol();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,CariHesapNo,CariHesapUnvani,Adres,İl,VergiDairesi,VergiNo from CariUnvaniFirma", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSil(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  CariUnvaniFirma where Id='" + ID + "'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGunceleme(string ID, string CariHesapNo, string CariHesapUnvani, string Adres, string İl, string VergiDairesi, string VergiNo)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  CariUnvaniFirma set CariHesapNo='" + CariHesapNo + "',CariHesapUnvani='" + CariHesapUnvani + "',Adres='" + Adres + "',İl='" + İl + "',VergiDairesi='" + VergiDairesi + "',VergiNo='" + VergiNo + "' where Id='" + ID + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkle(string CariHesapNo, string CariHesapUnvani, string Adres, string İl, string VergiDairesi, string VergiNo)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("Insert into  CariUnvaniFirma (CariHesapNo,CariHesapUnvani,Adres,İl,VergiDairesi,VergiNo) Values ('" + CariHesapNo + "','" + CariHesapUnvani + "','" + Adres + "','" + İl + "','" + VergiDairesi + "','" + VergiNo + "')", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }
    }
}
