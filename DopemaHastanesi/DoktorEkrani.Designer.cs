namespace DopemaHastanesi
{
    partial class DoktorEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorEkrani));
            this.randevuDataGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ilaçYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.randevuTamamlandıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.randevuİptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tumGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ilacGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tumGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilacGrid)).BeginInit();
            this.SuspendLayout();
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
            this.randevuDataGrid.Location = new System.Drawing.Point(3, 3);
            this.randevuDataGrid.Name = "randevuDataGrid";
            this.randevuDataGrid.ReadOnly = true;
            this.randevuDataGrid.RowHeadersVisible = false;
            this.randevuDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.randevuDataGrid.Size = new System.Drawing.Size(683, 505);
            this.randevuDataGrid.TabIndex = 3;
            this.randevuDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevuDataGrid_CellContentDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem,
            this.toolStripSeparator2,
            this.ilaçYazToolStripMenuItem,
            this.toolStripSeparator3,
            this.randevuTamamlandıToolStripMenuItem,
            this.toolStripSeparator1,
            this.randevuİptalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 110);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // ilaçYazToolStripMenuItem
            // 
            this.ilaçYazToolStripMenuItem.Name = "ilaçYazToolStripMenuItem";
            this.ilaçYazToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ilaçYazToolStripMenuItem.Text = "İlaç Yaz";
            this.ilaçYazToolStripMenuItem.Click += new System.EventHandler(this.ilaçYazToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // randevuTamamlandıToolStripMenuItem
            // 
            this.randevuTamamlandıToolStripMenuItem.Name = "randevuTamamlandıToolStripMenuItem";
            this.randevuTamamlandıToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.randevuTamamlandıToolStripMenuItem.Text = "Randevu Tamamlandı!";
            this.randevuTamamlandıToolStripMenuItem.Click += new System.EventHandler(this.randevuTamamlandıToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // randevuİptalToolStripMenuItem
            // 
            this.randevuİptalToolStripMenuItem.Name = "randevuİptalToolStripMenuItem";
            this.randevuİptalToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.randevuİptalToolStripMenuItem.Text = "Randevu İptal!";
            this.randevuİptalToolStripMenuItem.Click += new System.EventHandler(this.randevuİptalToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip2;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 537);
            this.tabControl1.TabIndex = 4;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.Size = new System.Drawing.Size(106, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem1.Text = "Yenile";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.randevuDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bugün ki Aktif Randevular";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tüm Randevular";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tumGrid);
            this.groupBox2.Location = new System.Drawing.Point(9, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 443);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tüm Randevular";
            // 
            // tumGrid
            // 
            this.tumGrid.AllowUserToAddRows = false;
            this.tumGrid.AllowUserToDeleteRows = false;
            this.tumGrid.AllowUserToResizeRows = false;
            this.tumGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tumGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tumGrid.ContextMenuStrip = this.contextMenuStrip2;
            this.tumGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tumGrid.Location = new System.Drawing.Point(3, 16);
            this.tumGrid.Name = "tumGrid";
            this.tumGrid.ReadOnly = true;
            this.tumGrid.RowHeadersVisible = false;
            this.tumGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tumGrid.Size = new System.Drawing.Size(666, 424);
            this.tumGrid.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta TC : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ilacGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(689, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yazılan İlaçlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ilacGrid
            // 
            this.ilacGrid.AllowUserToAddRows = false;
            this.ilacGrid.AllowUserToDeleteRows = false;
            this.ilacGrid.AllowUserToResizeRows = false;
            this.ilacGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ilacGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilacGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ilacGrid.Location = new System.Drawing.Point(3, 3);
            this.ilacGrid.Name = "ilacGrid";
            this.ilacGrid.ReadOnly = true;
            this.ilacGrid.RowHeadersVisible = false;
            this.ilacGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ilacGrid.Size = new System.Drawing.Size(683, 505);
            this.ilacGrid.TabIndex = 5;
            // 
            // DoktorEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 537);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoktorEkrani";
            this.Text = "Doktor Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktorEkrani_FormClosing);
            this.Load += new System.EventHandler(this.DoktorEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randevuDataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tumGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ilacGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView randevuDataGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuTamamlandıToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem randevuİptalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem ilaçYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tumGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ilacGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}