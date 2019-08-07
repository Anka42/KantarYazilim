using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using taralsa.Class;

namespace taralsa
{
    public partial class SabitDara : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;Initial Catalog=kntrkullanici;Integrated Security=True");
        int i;
        SabitDaraCls sabit = new SabitDaraCls();
        public void DataGridYenile()
        {
            dgwProducts2.DataSource = sabit.TabloyuGetir();
        }
        public SabitDara()
        {
            InitializeComponent();
            DataGridYenile();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Plaka No";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *FROM SabitDaraliArac";
            cmd.Connection = baglanti;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["PlakaNo"]);
            }
            baglanti.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Cari Ünvanı-Firma";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *FROM SabitDaraliArac";
            cmd.Connection = baglanti;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CariUnvaniFirma"]);
            }
            baglanti.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Şöfer Adı";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *FROM SabitDaraliArac";
            cmd.Connection = baglanti;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SöferAdi"]);
            }
            baglanti.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Operatör Adı";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *FROM SabitDaraliArac";
            cmd.Connection = baglanti;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["OperatörAdi"]);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgwProducts2.Rows[0].Selected = true;
            i = 0;
            dgwProducts2.FirstDisplayedScrollingRowIndex = i;
            dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
            dgwProducts2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i -= 1;
                dgwProducts2.Rows[i].Selected = true;
                dgwProducts2.FirstDisplayedScrollingRowIndex = i;
                dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
                dgwProducts2.Refresh();
            }
            else
            {
                i = dgwProducts2.Rows.Count - 1;
                dgwProducts2.Rows[i].Selected = true;
                dgwProducts2.FirstDisplayedScrollingRowIndex = i;
                dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
                dgwProducts2.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i < dgwProducts2.Rows.Count - 1)
            {
                i += 1;
                dgwProducts2.Rows[i].Selected = true;
                dgwProducts2.FirstDisplayedScrollingRowIndex = i;
                dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
                dgwProducts2.Refresh();
            }
            else
            {
                dgwProducts2.Rows[0].Selected = true;
                i = 0;
                dgwProducts2.FirstDisplayedScrollingRowIndex = i;
                dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
                dgwProducts2.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgwProducts2.Rows[dgwProducts2.Rows.Count - 1].Selected = true;
            i = dgwProducts2.Rows.Count - 1;
            dgwProducts2.FirstDisplayedScrollingRowIndex = i;
            dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
            dgwProducts2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridYenile();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AnaSyfa ana = new AnaSyfa();
            ana.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SabitDara_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "İLK KAYIT");
            Aciklama.SetToolTip(button6, "ÖNCEKİ KAYIT");
            Aciklama.SetToolTip(button3, "SONRAKİ KAYIT");
            Aciklama.SetToolTip(button2, "SON KAYIT");
            Aciklama.SetToolTip(button4, "YENİLE");
            Aciklama.SetToolTip(button12, "SEÇ");
            Aciklama.SetToolTip(btnExit, "ÇIKIŞ");
        }
    }
}
