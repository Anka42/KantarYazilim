using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taralsa
{
    public partial class AnaSyfa : Form
    {
        public AnaSyfa()
        {
            InitializeComponent();
        }

        private void aracÇıkışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void sabitDaralıTartımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SabitDara frm4 = new SabitDara();
            frm4.Show();

        }

        private void sabitDaralıAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Cari_Click(object sender, EventArgs e)
        {
            CariUnvan car = new CariUnvan();
            car.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SevkYeri sevk = new SevkYeri();
            sevk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MalzemeBilgileri malze = new MalzemeBilgileri();
            malze.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SabitDara sabitDara = new SabitDara();
            sabitDara.Show();
        }

        private void malzemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MalzemeBilgileri malze1 = new MalzemeBilgileri();
            malze1.Show();
        }

        private void cariUnvanFirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariUnvan car1 = new CariUnvan();
            car1.Show();
        }

        private void sevkYeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SevkYeri sevk1 = new SevkYeri();
            sevk1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Height==50)
            {
                this.WindowState = FormWindowState.Maximized;
                panel1.Height = 51;
            }
            else 
            {
                this.WindowState = FormWindowState.Normal;
                panel1.Height = 50;
            }
            
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRaporlar raporlar = new FrmRaporlar();
            raporlar.Show();
        }
    }
}
