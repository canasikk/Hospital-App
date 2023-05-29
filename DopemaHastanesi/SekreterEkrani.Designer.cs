namespace DopemaHastanesi
{
    partial class SekreterEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterEkrani));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saat = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaÜyeOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.sikayetTxt = new System.Windows.Forms.TextBox();
            this.saatCmb = new System.Windows.Forms.ComboBox();
            this.tarihDate = new System.Windows.Forms.DateTimePicker();
            this.doktorCmb = new System.Windows.Forms.ComboBox();
            this.hastaCmb = new System.Windows.Forms.ComboBox();
            this.bransCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.randevuDataGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.randevuİptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tekHastayaDuyuruGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.tarih,
            this.toolStripStatusLabel1,
            this.saat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1043, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tarih
            // 
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(65, 17);
            this.tarih.Text = "00/00/0000";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // saat
            // 
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(34, 17);
            this.saat.Text = "00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaÜyeOluşturToolStripMenuItem,
            this.toolStripSeparator1,
            this.tekHastayaDuyuruGönderToolStripMenuItem});
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            // 
            // hastaÜyeOluşturToolStripMenuItem
            // 
            this.hastaÜyeOluşturToolStripMenuItem.Name = "hastaÜyeOluşturToolStripMenuItem";
            this.hastaÜyeOluşturToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.hastaÜyeOluşturToolStripMenuItem.Text = "Hasta Oluştur";
            this.hastaÜyeOluşturToolStripMenuItem.Click += new System.EventHandler(this.hastaÜyeOluşturToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnRandevu);
            this.groupBox2.Controls.Add(this.sikayetTxt);
            this.groupBox2.Controls.Add(this.saatCmb);
            this.groupBox2.Controls.Add(this.tarihDate);
            this.groupBox2.Controls.Add(this.doktorCmb);
            this.groupBox2.Controls.Add(this.hastaCmb);
            this.groupBox2.Controls.Add(this.bransCmb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 483);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // btnRandevu
            // 
            this.btnRandevu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandevu.Location = new System.Drawing.Point(265, 449);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(103, 23);
            this.btnRandevu.TabIndex = 5;
            this.btnRandevu.Text = "Randevu Ver";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // sikayetTxt
            // 
            this.sikayetTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sikayetTxt.Location = new System.Drawing.Point(92, 172);
            this.sikayetTxt.Multiline = true;
            this.sikayetTxt.Name = "sikayetTxt";
            this.sikayetTxt.Size = new System.Drawing.Size(276, 271);
            this.sikayetTxt.TabIndex = 4;
            // 
            // saatCmb
            // 
            this.saatCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saatCmb.FormattingEnabled = true;
            this.saatCmb.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30"});
            this.saatCmb.Location = new System.Drawing.Point(92, 144);
            this.saatCmb.Name = "saatCmb";
            this.saatCmb.Size = new System.Drawing.Size(276, 21);
            this.saatCmb.TabIndex = 3;
            // 
            // tarihDate
            // 
            this.tarihDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihDate.Location = new System.Drawing.Point(92, 117);
            this.tarihDate.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.tarihDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.tarihDate.Name = "tarihDate";
            this.tarihDate.Size = new System.Drawing.Size(276, 20);
            this.tarihDate.TabIndex = 2;
            this.tarihDate.Value = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            // 
            // doktorCmb
            // 
            this.doktorCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doktorCmb.FormattingEnabled = true;
            this.doktorCmb.Location = new System.Drawing.Point(92, 89);
            this.doktorCmb.Name = "doktorCmb";
            this.doktorCmb.Size = new System.Drawing.Size(276, 21);
            this.doktorCmb.TabIndex = 1;
            // 
            // hastaCmb
            // 
            this.hastaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hastaCmb.FormattingEnabled = true;
            this.hastaCmb.Location = new System.Drawing.Point(92, 33);
            this.hastaCmb.Name = "hastaCmb";
            this.hastaCmb.Size = new System.Drawing.Size(276, 21);
            this.hastaCmb.TabIndex = 1;
            this.hastaCmb.SelectedValueChanged += new System.EventHandler(this.hastaCmb_SelectedValueChanged);
            // 
            // bransCmb
            // 
            this.bransCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bransCmb.FormattingEnabled = true;
            this.bransCmb.Location = new System.Drawing.Point(92, 61);
            this.bransCmb.Name = "bransCmb";
            this.bransCmb.Size = new System.Drawing.Size(276, 21);
            this.bransCmb.TabIndex = 1;
            this.bransCmb.SelectedIndexChanged += new System.EventHandler(this.bransCmb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hastalık Bilgisi : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Saat : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tarih : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doktor : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hasta Seç :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branş : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.randevuDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(404, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 486);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // randevuDataGrid
            // 
            this.randevuDataGrid.AllowUserToAddRows = false;
            this.randevuDataGrid.AllowUserToDeleteRows = false;
            this.randevuDataGrid.AllowUserToResizeRows = false;
            this.randevuDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.randevuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuDataGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.randevuDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randevuDataGrid.Location = new System.Drawing.Point(3, 16);
            this.randevuDataGrid.Name = "randevuDataGrid";
            this.randevuDataGrid.ReadOnly = true;
            this.randevuDataGrid.RowHeadersVisible = false;
            this.randevuDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.randevuDataGrid.Size = new System.Drawing.Size(622, 467);
            this.randevuDataGrid.TabIndex = 2;
            this.randevuDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevuDataGrid_CellContentDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem,
            this.toolStripSeparator2,
            this.randevuİptalEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 54);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // randevuİptalEtToolStripMenuItem
            // 
            this.randevuİptalEtToolStripMenuItem.Name = "randevuİptalEtToolStripMenuItem";
            this.randevuİptalEtToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.randevuİptalEtToolStripMenuItem.Text = "Randevu İptal Et";
            this.randevuİptalEtToolStripMenuItem.Click += new System.EventHandler(this.randevuİptalEtToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel3.Text = "Sekreter Adı Soyadı";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // tekHastayaDuyuruGönderToolStripMenuItem
            // 
            this.tekHastayaDuyuruGönderToolStripMenuItem.Name = "tekHastayaDuyuruGönderToolStripMenuItem";
            this.tekHastayaDuyuruGönderToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tekHastayaDuyuruGönderToolStripMenuItem.Text = "Tek Hastaya Mail Gönder";
            this.tekHastayaDuyuruGönderToolStripMenuItem.Click += new System.EventHandler(this.tekHastayaDuyuruGönderToolStripMenuItem_Click);
            // 
            // SekreterEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1059, 583);
            this.Name = "SekreterEkrani";
            this.Text = "Sekreter Yönetimi";
            this.Activated += new System.EventHandler(this.SekreterEkrani_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SekreterEkrani_FormClosing);
            this.Load += new System.EventHandler(this.SekreterEkrani_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.randevuDataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel saat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tarih;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaÜyeOluşturToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.TextBox sikayetTxt;
        private System.Windows.Forms.ComboBox saatCmb;
        private System.Windows.Forms.DateTimePicker tarihDate;
        private System.Windows.Forms.ComboBox doktorCmb;
        private System.Windows.Forms.ComboBox bransCmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox hastaCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuİptalEtToolStripMenuItem;
        private System.Windows.Forms.DataGridView randevuDataGrid;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tekHastayaDuyuruGönderToolStripMenuItem;
    }
}