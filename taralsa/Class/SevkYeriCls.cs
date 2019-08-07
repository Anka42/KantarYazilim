using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace taralsa.Class
{
    class SevkYeriCls
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
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,KodNo,KodAdi,Aciklama,Not1,Not2,Not3 from SevkYeri", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSil(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  SevkYeri where Id='" + ID + "'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGunceleme(string ID, string KodNo, string KodAdi, string Aciklama, string Not1, string Not2, string Not3)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  SevkYeri set KodNo='" + KodNo + "',KodAdi='" + KodAdi + "',Aciklama='" + Aciklama + "',Not1='" + Not1 + "',Not2='" + Not2 + "',Not3='" + Not3 + "' where Id='" + ID + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkle(string KodNo, string KodAdi, string Aciklama, string Not1, string Not2, string Not3)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("Insert into  SevkYeri (KodNo,KodAdi,Aciklama,Not1,Not2,Not3) Values ('" + KodNo + "','" + KodAdi + "','" + Aciklama + "','" + Not1 + "','" + Not2 + "','" + Not3 + "')", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }
    }
}
