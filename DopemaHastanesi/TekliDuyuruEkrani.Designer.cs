namespace DopemaHastanesi
{
    partial class TekliDuyuruEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TekliDuyuruEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.hastaCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.konuTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mesajTxt = new System.Windows.Forms.TextBox();
            this.GonderBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Seç : ";
            // 
            // hastaCmb
            // 
            this.hastaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hastaCmb.FormattingEnabled = true;
            this.hastaCmb.Location = new System.Drawing.Point(91, 13);
            this.hastaCmb.Name = "hastaCmb";
            this.hastaCmb.Size = new System.Drawing.Size(223, 21);
            this.hastaCmb.TabIndex = 1;
            this.hastaCmb.SelectedValueChanged += new System.EventHandler(this.hastaCmb_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EPosta : ";
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(91, 43);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(223, 20);
            this.mailTxt.TabIndex = 3;
            // 
            // konuTxt
            // 
            this.konuTxt.Location = new System.Drawing.Point(91, 72);
            this.konuTxt.MaxLength = 25;
            this.konuTxt.Name = "konuTxt";
            this.konuTxt.Size = new System.Drawing.Size(223, 20);
            this.konuTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Konu Başlığı : ";
            // 
            // mesajTxt
            // 
            this.mesajTxt.Location = new System.Drawing.Point(91, 101);
            this.mesajTxt.Multiline = true;
            this.mesajTxt.Name = "mesajTxt";
            this.mesajTxt.Size = new System.Drawing.Size(223, 169);
            this.mesajTxt.TabIndex = 6;
            // 
            // GonderBtn
            // 
            this.GonderBtn.Location = new System.Drawing.Point(239, 276);
            this.GonderBtn.Name = "GonderBtn";
            this.GonderBtn.Size = new System.Drawing.Size(75, 23);
            this.GonderBtn.TabIndex = 7;
            this.GonderBtn.Text = "Gönder";
            this.GonderBtn.UseVisualStyleBackColor = true;
            this.GonderBtn.Click += new System.EventHandler(this.GonderBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mesaj :";
            // 
            // TekliDuyuruEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 314);
            this.Controls.Add(this.GonderBtn);
            this.Controls.Add(this.mesajTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.konuTxt);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hastaCmb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 353);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 353);
            this.Name = "TekliDuyuruEkrani";
            this.Text = "Tekli Duyuru Ekranı";
            this.Load += new System.EventHandler(this.TekliDuyuruEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hastaCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox konuTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mesajTxt;
        private System.Windows.Forms.Button GonderBtn;
        private System.Windows.Forms.Label label4;
    }
}