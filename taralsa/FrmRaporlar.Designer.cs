namespace taralsa
{
    partial class FrmRaporlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsDara = new System.Windows.Forms.BindingSource(this.components);
            this.kntrkullaniciDataSet = new taralsa.kntrkullaniciDataSet();
            this.sabitDaraliAracTableAdapter = new taralsa.kntrkullaniciDataSetTableAdapters.SabitDaraliAracTableAdapter();
            this.bsCari = new System.Windows.Forms.BindingSource(this.components);
            this.cariUnvaniFirmaTableAdapter = new taralsa.kntrkullaniciDataSetTableAdapters.CariUnvaniFirmaTableAdapter();
            this.bsMalzeme = new System.Windows.Forms.BindingSource(this.components);
            this.malzemeBilgileriTableAdapter = new taralsa.kntrkullaniciDataSetTableAdapters.MalzemeBilgileriTableAdapter();
            this.bsSevk = new System.Windows.Forms.BindingSource(this.components);
            this.sevkYeriTableAdapter = new taralsa.kntrkullaniciDataSetTableAdapters.SevkYeriTableAdapter();
            this.bsCikis = new System.Windows.Forms.BindingSource(this.components);
            this.cikisYapmayanAracTableAdapter = new taralsa.kntrkullaniciDataSetTableAdapters.CikisYapmayanAracTableAdapter();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kntrkullaniciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMalzeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSevk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sabit Daralı Araç";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cari Unvanı-Firma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cıkış Yapamayan Araç";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Malzeme Bilgileri";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sevk Yeri";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // bsDara
            // 
            this.bsDara.DataMember = "SabitDaraliArac";
            this.bsDara.DataSource = this.kntrkullaniciDataSet;
            // 
            // kntrkullaniciDataSet
            // 
            this.kntrkullaniciDataSet.DataSetName = "kntrkullaniciDataSet";
            this.kntrkullaniciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sabitDaraliAracTableAdapter
            // 
            this.sabitDaraliAracTableAdapter.ClearBeforeFill = true;
            // 
            // bsCari
            // 
            this.bsCari.DataMember = "CariUnvaniFirma";
            this.bsCari.DataSource = this.kntrkullaniciDataSet;
            // 
            // cariUnvaniFirmaTableAdapter
            // 
            this.cariUnvaniFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // bsMalzeme
            // 
            this.bsMalzeme.DataMember = "MalzemeBilgileri";
            this.bsMalzeme.DataSource = this.kntrkullaniciDataSet;
            // 
            // malzemeBilgileriTableAdapter
            // 
            this.malzemeBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // bsSevk
            // 
            this.bsSevk.DataMember = "SevkYeri";
            this.bsSevk.DataSource = this.kntrkullaniciDataSet;
            // 
            // sevkYeriTableAdapter
            // 
            this.sevkYeriTableAdapter.ClearBeforeFill = true;
            // 
            // bsCikis
            // 
            this.bsCikis.DataMember = "CikisYapmayanArac";
            this.bsCikis.DataSource = this.kntrkullaniciDataSet;
            // 
            // cikisYapmayanAracTableAdapter
            // 
            this.cikisYapmayanAracTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kntrkullaniciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMalzeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSevk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCikis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bsDara;
        private kntrkullaniciDataSet kntrkullaniciDataSet;
        private kntrkullaniciDataSetTableAdapters.SabitDaraliAracTableAdapter sabitDaraliAracTableAdapter;
        private System.Windows.Forms.BindingSource bsCari;
        private kntrkullaniciDataSetTableAdapters.CariUnvaniFirmaTableAdapter cariUnvaniFirmaTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingSource bsMalzeme;
        private kntrkullaniciDataSetTableAdapters.MalzemeBilgileriTableAdapter malzemeBilgileriTableAdapter;
        private System.Windows.Forms.BindingSource bsSevk;
        private kntrkullaniciDataSetTableAdapters.SevkYeriTableAdapter sevkYeriTableAdapter;
        private System.Windows.Forms.BindingSource bsCikis;
        private kntrkullaniciDataSetTableAdapters.CikisYapmayanAracTableAdapter cikisYapmayanAracTableAdapter;
    }
}