namespace taralsa
{
    partial class frmgiris
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
            this.lblmetin = new System.Windows.Forms.Label();
            this.lblkllnci = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.txtpasword = new System.Windows.Forms.TextBox();
            this.bttngiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmetin
            // 
            this.lblmetin.AutoSize = true;
            this.lblmetin.Font = new System.Drawing.Font("Minion Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmetin.ForeColor = System.Drawing.Color.DarkRed;
            this.lblmetin.Location = new System.Drawing.Point(94, 27);
            this.lblmetin.Name = "lblmetin";
            this.lblmetin.Size = new System.Drawing.Size(139, 40);
            this.lblmetin.TabIndex = 0;
            this.lblmetin.Text = "TARALSA";
            // 
            // lblkllnci
            // 
            this.lblkllnci.AutoSize = true;
            this.lblkllnci.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkllnci.Location = new System.Drawing.Point(14, 87);
            this.lblkllnci.Name = "lblkllnci";
            this.lblkllnci.Size = new System.Drawing.Size(161, 25);
            this.lblkllnci.TabIndex = 1;
            this.lblkllnci.Text = "KULLANICI ADI :";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifre.Location = new System.Drawing.Point(14, 135);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(72, 25);
            this.lblsifre.TabIndex = 2;
            this.lblsifre.Text = "ŞİFRE :";
            // 
            // txtkullanici
            // 
            this.txtkullanici.BackColor = System.Drawing.Color.MintCream;
            this.txtkullanici.Location = new System.Drawing.Point(181, 92);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(153, 20);
            this.txtkullanici.TabIndex = 3;
            // 
            // txtpasword
            // 
            this.txtpasword.BackColor = System.Drawing.Color.MintCream;
            this.txtpasword.Location = new System.Drawing.Point(181, 135);
            this.txtpasword.Name = "txtpasword";
            this.txtpasword.Size = new System.Drawing.Size(153, 20);
            this.txtpasword.TabIndex = 4;
            // 
            // bttngiris
            // 
            this.bttngiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttngiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttngiris.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttngiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttngiris.Location = new System.Drawing.Point(101, 188);
            this.bttngiris.Name = "bttngiris";
            this.bttngiris.Size = new System.Drawing.Size(134, 51);
            this.bttngiris.TabIndex = 5;
            this.bttngiris.Text = "GİRİŞ";
            this.bttngiris.UseVisualStyleBackColor = false;
            this.bttngiris.Click += new System.EventHandler(this.bttngiris_Click);
            // 
            // frmgiris
            // 
            this.AcceptButton = this.bttngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(350, 267);
            this.Controls.Add(this.bttngiris);
            this.Controls.Add(this.txtpasword);
            this.Controls.Add(this.txtkullanici);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkllnci);
            this.Controls.Add(this.lblmetin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmgiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmetin;
        private System.Windows.Forms.Label lblkllnci;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.TextBox txtpasword;
        private System.Windows.Forms.Button bttngiris;
    }
}