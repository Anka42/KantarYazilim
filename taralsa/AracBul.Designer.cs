namespace taralsa
{
    partial class AracBul
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlakaNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TartimSeriNo = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnCikisYapamayan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 43);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Araç Çıkışı - Araç Bul Tartım Seri Nosunu veya Plaka Kodunu Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka No:";
            // 
            // PlakaNo
            // 
            this.PlakaNo.Location = new System.Drawing.Point(111, 82);
            this.PlakaNo.Name = "PlakaNo";
            this.PlakaNo.Size = new System.Drawing.Size(100, 20);
            this.PlakaNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tartım Seri No:";
            // 
            // TartimSeriNo
            // 
            this.TartimSeriNo.Location = new System.Drawing.Point(111, 117);
            this.TartimSeriNo.Name = "TartimSeriNo";
            this.TartimSeriNo.Size = new System.Drawing.Size(100, 20);
            this.TartimSeriNo.TabIndex = 5;
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(231, 76);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(90, 30);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(346, 76);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 30);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnCikisYapamayan
            // 
            this.btnCikisYapamayan.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYapamayan.Location = new System.Drawing.Point(231, 114);
            this.btnCikisYapamayan.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikisYapamayan.Name = "btnCikisYapamayan";
            this.btnCikisYapamayan.Size = new System.Drawing.Size(205, 30);
            this.btnCikisYapamayan.TabIndex = 8;
            this.btnCikisYapamayan.Text = "Çıkış Yapmayan Araç Lİstesi";
            this.btnCikisYapamayan.UseVisualStyleBackColor = true;
            // 
            // AracBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 159);
            this.Controls.Add(this.btnCikisYapamayan);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.TartimSeriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlakaNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AracBul";
            this.Text = "Araç Bul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlakaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TartimSeriNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnCikisYapamayan;
    }
}