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
    public partial class SevkYeri : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=kntrkullanici;Integrated Security=True");
        SevkYeriCls sevk = new SevkYeriCls();
        public void DataGridYenile()
        {
            dgwProducts2.DataSource = sevk.TabloyuGetir();
        }

        public SevkYeri()
        {
            InitializeComponent();
            DataGridYenile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sevk.YeniSatirEkle(textBox5.Text, textBox4.Text, textBox3.Text, textBox7.Text, textBox1.Text, textBox6.Text);
            DataGridYenile();
        }

        private void btnKayitsil_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();
            Secim = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz", "Taralsa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Secim == DialogResult.Yes)
            {
                string ID = dgwProducts2.Rows[dgwProducts2.CurrentRow.Index].Cells[0].Value.ToString();
                sevk.SatiriSil(ID);
                DataGridYenile();
            }
            else
            {
                MessageBox.Show("İşlem yapılmadı", "Taralsa");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridYenile();
            textBox1.Text = string.Empty; textBox3.Text = string.Empty; textBox4.Text = string.Empty;
            textBox5.Text = string.Empty; textBox6.Text = string.Empty; textBox7.Text = string.Empty;
        }

        public void satirDegisti()
        {
            textBox5.Text = dgwProducts2.Rows[dgwProducts2.CurrentRow.Index].Cells[1].Value.ToString();
            textBox4.Text = dgwProducts2.Rows[dgwProducts2.CurrentRow.Index].Cells[2].Value.ToString();
            textBox3.Text = dgwProducts2.Rows[dgwProducts2.CurrentRow.Index].Cells[3].Value.ToString();
            textBox7.Text = dgwProducts2.Rows[dgwProducts2.CurrentRow.Index].Cells[4].Value.ToString();
            textBox1.Text = dgwProducts2.Rows[dgwProducts2.CurrentRow.Index].Cells[5].Value.ToString();
            textBox6.Text = dgwProducts2.Rows[dgwProducts2.CurrentRow.Index].Cells[6].Value.ToString();
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dgwProducts2.SelectedRows.Count != 0)
            {
                string ID = dgwProducts2.Rows[dgwProducts2.CurrentRow.Index].Cells[0].Value.ToString();
                sevk.SatirGunceleme(ID, textBox5.Text, textBox4.Text, textBox3.Text, textBox7.Text, textBox1.Text, textBox6.Text);
                DataGridYenile();
            }
            else
            {
                MessageBox.Show("Secim Yapınız.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            satirDegisti();
        }
        int i;
        private void button6_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i -= 1;
                dgwProducts2.Rows[i].Selected = true;
                dgwProducts2.FirstDisplayedScrollingRowIndex = i;
                dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
                dgwProducts2.Refresh();
                satirDegisti();
            }
            else
            {
                i = dgwProducts2.Rows.Count - 1;
                dgwProducts2.Rows[i].Selected = true;
                dgwProducts2.FirstDisplayedScrollingRowIndex = i;
                dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
                dgwProducts2.Refresh();
                satirDegisti();
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
                satirDegisti();
            }
            else
            {
                dgwProducts2.Rows[0].Selected = true;
                i = 0;
                dgwProducts2.FirstDisplayedScrollingRowIndex = i;
                dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
                dgwProducts2.Refresh();
                satirDegisti();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgwProducts2.Rows[0].Selected = true;
            i = 0;
            dgwProducts2.FirstDisplayedScrollingRowIndex = i;
            dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
            dgwProducts2.Refresh();
            satirDegisti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgwProducts2.Rows[dgwProducts2.Rows.Count - 1].Selected = true;
            i = dgwProducts2.Rows.Count - 1;
            dgwProducts2.FirstDisplayedScrollingRowIndex = i;
            dgwProducts2.CurrentCell = dgwProducts2.Rows[i].Cells[0];
            dgwProducts2.Refresh();
            satirDegisti();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from SevkYeri Where KodNo like'%" + textBox5.Text + "%'", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            dataAdapter.Fill(data, "SevkYeri");
            dgwProducts2.DataSource = data.Tables[0];
            conn.Close();
        }

        private void SevkYeri_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "İLK KAYIT");
            Aciklama.SetToolTip(button6, "ÖNCEKİ KAYIT");
            Aciklama.SetToolTip(button3, "SONRAKİ KAYIT");
            Aciklama.SetToolTip(button2, "SON KAYIT");
            Aciklama.SetToolTip(button5, "KAYIT EKLE");
            Aciklama.SetToolTip(btnKayitsil, "KAYIT SİL");
            Aciklama.SetToolTip(button12, "DEĞİŞİKLİĞİ KAYDET");
            Aciklama.SetToolTip(button7, "DEĞİŞİKLİĞİ KAYDETME");
            Aciklama.SetToolTip(button4, "YENİLE");
            Aciklama.SetToolTip(button13, "ARA");
            Aciklama.SetToolTip(btnExit, "ÇIKIŞ");
        }
    }
}
