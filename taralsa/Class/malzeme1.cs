using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace taralsa.Class
{
    class malzeme1
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=kntrkullanici;user id = sa; password=Qwerty1!;Integrated Security =false");

        protected void sqlcontrol()
        {
            try { conn.Close(); }
            catch { }
        }
        public DataTable TabloyuGetir()
        {
            sqlcontrol();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Id,MalzemeNo,MalzemeAdi,Aciklama,BirimFiyati,Not1,Not2,Not3 from MalzemeBilgileri", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public void SatiriSil(string ID)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  MalzemeBilgileri where Id='" + ID+"'", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }

        public void SatirGunceleme (string ID, string MalzemeNo, string MalzemeAdi, string Aciklama, string BirimFiyati, string Not1, string Not2, string Not3)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE  MalzemeBilgileri set MalzemeNo='" + MalzemeNo + "',MalzemeAdi='" + MalzemeAdi + "',Aciklama='" + Aciklama + "', BirimFiyati='" + BirimFiyati + "',Not1='" + Not1 + "',Not2='" + Not2 + "',Not3='" + Not3 + "' where Id='" + ID +"'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void YeniSatirEkle(string MalzemeNo, string MalzemeAdi, string Aciklama, string BirimFiyati, string Not1, string Not2, string Not3)
        {
            sqlcontrol();
            conn.Open();
            SqlCommand kmt = new SqlCommand("Insert into  MalzemeBilgileri (MalzemeNo,MalzemeAdi,Aciklama,BirimFiyati,Not1,Not2,Not3) Values ('" + MalzemeNo+ "','" + MalzemeAdi + "','" + Aciklama + "','" + BirimFiyati + "','" + Not1 + "','" + Not2+ "','" + Not3 + "')", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
        }
    }
}
