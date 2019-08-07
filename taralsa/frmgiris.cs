using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taralsa
{
    public partial class frmgiris : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;Initial Catalog=kntrkullanici;Integrated Security=True");
        public frmgiris()
        {
            InitializeComponent();
        }

        private void bttngiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From kllncipasw where kulnci=@kullanici AND pasword=@sifresi";
                SqlParameter prm1 = new SqlParameter("kullanici", txtkullanici.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtpasword.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                adptr.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    AnaSyfa frm = new AnaSyfa();
                    frm.Show();
                   
                }
                
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Hatalı giriş yaptınız!!!");

            }
        }

    }
}
