namespace DopemaHastanesi
{
    partial class HastaOlusturEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaOlusturEkrani));
            this.olusturBtn = new System.Windows.Forms.Button();
            this.tcTxt = new System.Windows.Forms.MaskedTextBox();
            this.mailTxt = new System.Windows.Forms.MaskedTextBox();
            this.cepTxt = new System.Windows.Forms.MaskedTextBox();
            this.kanCmb = new System.Windows.Forms.ComboBox();
            this.dogumCmb = new System.Windows.Forms.ComboBox();
            this.cinsiyetCmb = new System.Windows.Forms.ComboBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hastaDogumDtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // olusturBtn
            // 
            this.olusturBtn.Location = new System.Drawing.Point(214, 287);
            this.olusturBtn.Name = "olusturBtn";
            this.olusturBtn.Size = new System.Drawing.Size(109, 23);
            this.olusturBtn.TabIndex = 12;
            this.olusturBtn.Text = "Hesap Oluştur";
            this.olusturBtn.UseVisualStyleBackColor = true;
            this.olusturBtn.Click += new System.EventHandler(this.olusturBtn_Click);
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(123, 18);
            this.tcTxt.Mask = "00000000000";
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(200, 20);
            this.tcTxt.TabIndex = 0;
            this.tcTxt.ValidatingType = typeof(int);
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(123, 261);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(200, 20);
            this.mailTxt.TabIndex = 8;
            // 
            // cepTxt
            // 
            this.cepTxt.Location = new System.Drawing.Point(123, 231);
            this.cepTxt.Mask = "(999) 000-0000";
            this.cepTxt.Name = "cepTxt";
            this.cepTxt.Size = new System.Drawing.Size(200, 20);
            this.cepTxt.TabIndex = 7;
            // 
            // kanCmb
            // 
            this.kanCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kanCmb.FormattingEnabled = true;
            this.kanCmb.Items.AddRange(new object[] {
            "AB Rh+",
            "AB Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "O Rh+",
            "O Rh-"});
            this.kanCmb.Location = new System.Drawing.Point(123, 200);
            this.kanCmb.Name = "kanCmb";
            this.kanCmb.Size = new System.Drawing.Size(200, 21);
            this.kanCmb.TabIndex = 6;
            // 
            // dogumCmb
            // 
            this.dogumCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dogumCmb.FormattingEnabled = true;
            this.dogumCmb.Items.AddRange(new object[] {
            "DİĞER",
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.dogumCmb.Location = new System.Drawing.Point(123, 139);
            this.dogumCmb.Name = "dogumCmb";
            this.dogumCmb.Size = new System.Drawing.Size(200, 21);
            this.dogumCmb.TabIndex = 4;
            // 
            // cinsiyetCmb
            // 
            this.cinsiyetCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyetCmb.FormattingEnabled = true;
            this.cinsiyetCmb.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cinsiyetCmb.Location = new System.Drawing.Point(123, 108);
            this.cinsiyetCmb.Name = "cinsiyetCmb";
            this.cinsiyetCmb.Size = new System.Drawing.Size(200, 21);
            this.cinsiyetCmb.TabIndex = 3;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(123, 78);
            this.soyadTxt.MaxLength = 25;
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(200, 20);
            this.soyadTxt.TabIndex = 2;
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(123, 48);
            this.adTxt.MaxLength = 10;
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(200, 20);
            this.adTxt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "E-Posta : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cep Telefonu : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kan Grubu : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Doğum Tarihi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Doğum Yeri : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cinsiyet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soyad :  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "TC Kimlik Numarası :";
            // 
            // hastaDogumDtp
            // 
            this.hastaDogumDtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hastaDogumDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDogumDtp.Location = new System.Drawing.Point(123, 170);
            this.hastaDogumDtp.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.hastaDogumDtp.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.hastaDogumDtp.Name = "hastaDogumDtp";
            this.hastaDogumDtp.Size = new System.Drawing.Size(200, 20);
            this.hastaDogumDtp.TabIndex = 5;
            // 
            // HastaOlusturEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 327);
            this.Controls.Add(this.hastaDogumDtp);
            this.Controls.Add(this.olusturBtn);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.cepTxt);
            this.Controls.Add(this.kanCmb);
            this.Controls.Add(this.dogumCmb);
            this.Controls.Add(this.cinsiyetCmb);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 366);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(355, 366);
            this.Name = "HastaOlusturEkrani";
            this.Text = "Hasta Hesabı Oluştur";
            this.Load += new System.EventHandler(this.HastaOlusturEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button olusturBtn;
        private System.Windows.Forms.MaskedTextBox tcTxt;
        private System.Windows.Forms.MaskedTextBox mailTxt;
        private System.Windows.Forms.MaskedTextBox cepTxt;
        private System.Windows.Forms.ComboBox kanCmb;
        private System.Windows.Forms.ComboBox dogumCmb;
        private System.Windows.Forms.ComboBox cinsiyetCmb;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker hastaDogumDtp;
    }
}