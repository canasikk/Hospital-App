namespace DopemaHastanesi
{
    partial class OturumEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OturumEkrani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.versiyonLbl = new System.Windows.Forms.Label();
            this.loginGrup = new System.Windows.Forms.GroupBox();
            this.pwTxt = new System.Windows.Forms.TextBox();
            this.tcTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // versiyonLbl
            // 
            this.versiyonLbl.AutoSize = true;
            this.versiyonLbl.BackColor = System.Drawing.Color.Transparent;
            this.versiyonLbl.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.versiyonLbl.Location = new System.Drawing.Point(12, 492);
            this.versiyonLbl.Name = "versiyonLbl";
            this.versiyonLbl.Size = new System.Drawing.Size(95, 15);
            this.versiyonLbl.TabIndex = 1;
            this.versiyonLbl.Text = "Versiyon : 1.0.1.1";
            // 
            // loginGrup
            // 
            this.loginGrup.BackColor = System.Drawing.Color.Transparent;
            this.loginGrup.Controls.Add(this.pwTxt);
            this.loginGrup.Controls.Add(this.tcTxt);
            this.loginGrup.Controls.Add(this.loginBtn);
            this.loginGrup.Controls.Add(this.label2);
            this.loginGrup.Controls.Add(this.label5);
            this.loginGrup.Controls.Add(this.label1);
            this.loginGrup.Location = new System.Drawing.Point(88, 218);
            this.loginGrup.Name = "loginGrup";
            this.loginGrup.Size = new System.Drawing.Size(829, 129);
            this.loginGrup.TabIndex = 3;
            this.loginGrup.TabStop = false;
            this.loginGrup.Visible = false;
            // 
            // pwTxt
            // 
            this.pwTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwTxt.Location = new System.Drawing.Point(343, 74);
            this.pwTxt.MaxLength = 25;
            this.pwTxt.MinimumSize = new System.Drawing.Size(331, 44);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.PasswordChar = '•';
            this.pwTxt.Size = new System.Drawing.Size(331, 29);
            this.pwTxt.TabIndex = 1;
            this.pwTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tcTxt
            // 
            this.tcTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcTxt.Location = new System.Drawing.Point(6, 74);
            this.tcTxt.MaxLength = 11;
            this.tcTxt.MinimumSize = new System.Drawing.Size(331, 44);
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(331, 29);
            this.tcTxt.TabIndex = 0;
            this.tcTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(680, 74);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(141, 29);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Giriş Yap";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(340, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(356, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hesaba Giriş Yap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(207, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(590, 84);
            this.label7.TabIndex = 7;
            this.label7.Text = "HASTANE SİSTEMİMİZE HOŞGELDİNİZ\r\nACİL ŞİFALAR DİLERİZ!..";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(469, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 19);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giriş Yap";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OturumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 516);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loginGrup);
            this.Controls.Add(this.versiyonLbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1042, 555);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1042, 555);
            this.Name = "OturumEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dopema Hastanesi Yetkili Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OturumEkrani_FormClosing);
            this.Load += new System.EventHandler(this.OturumEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginGrup.ResumeLayout(false);
            this.loginGrup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label versiyonLbl;
        private System.Windows.Forms.GroupBox loginGrup;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pwTxt;
        private System.Windows.Forms.TextBox tcTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}