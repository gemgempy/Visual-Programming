
namespace project
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.animalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hewanBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHewanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hewanMasukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hewanTeradopsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasilDonasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailDonasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailKatalogHewanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKatalogHewanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateDetailDonasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readTxtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1184, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 647);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalsToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.generateTxtToolStripMenuItem,
            this.readTxtToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // animalsToolStripMenuItem
            // 
            this.animalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hewanBaruToolStripMenuItem,
            this.editHewanToolStripMenuItem});
            this.animalsToolStripMenuItem.Name = "animalsToolStripMenuItem";
            this.animalsToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.animalsToolStripMenuItem.Text = "Animals";
            // 
            // hewanBaruToolStripMenuItem
            // 
            this.hewanBaruToolStripMenuItem.Name = "hewanBaruToolStripMenuItem";
            this.hewanBaruToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.hewanBaruToolStripMenuItem.Text = "Hewan Baru";
            this.hewanBaruToolStripMenuItem.Click += new System.EventHandler(this.hewanBaruToolStripMenuItem_Click);
            // 
            // editHewanToolStripMenuItem
            // 
            this.editHewanToolStripMenuItem.Name = "editHewanToolStripMenuItem";
            this.editHewanToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.editHewanToolStripMenuItem.Text = "Edit Hewan";
            this.editHewanToolStripMenuItem.Click += new System.EventHandler(this.editHewanToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hewanMasukToolStripMenuItem,
            this.hewanTeradopsiToolStripMenuItem,
            this.hasilDonasiToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // hewanMasukToolStripMenuItem
            // 
            this.hewanMasukToolStripMenuItem.Name = "hewanMasukToolStripMenuItem";
            this.hewanMasukToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.hewanMasukToolStripMenuItem.Text = "Hewan Masuk";
            this.hewanMasukToolStripMenuItem.Click += new System.EventHandler(this.hewanMasukToolStripMenuItem_Click);
            // 
            // hewanTeradopsiToolStripMenuItem
            // 
            this.hewanTeradopsiToolStripMenuItem.Name = "hewanTeradopsiToolStripMenuItem";
            this.hewanTeradopsiToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.hewanTeradopsiToolStripMenuItem.Text = "Hewan Teradopsi";
            this.hewanTeradopsiToolStripMenuItem.Click += new System.EventHandler(this.hewanTeradopsiToolStripMenuItem_Click);
            // 
            // hasilDonasiToolStripMenuItem
            // 
            this.hasilDonasiToolStripMenuItem.Name = "hasilDonasiToolStripMenuItem";
            this.hasilDonasiToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.hasilDonasiToolStripMenuItem.Text = "Hasil Donasi";
            this.hasilDonasiToolStripMenuItem.Click += new System.EventHandler(this.hasilDonasiToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailDonasiToolStripMenuItem,
            this.detailKatalogHewanToolStripMenuItem});
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.detailToolStripMenuItem.Text = "Detail";
            // 
            // detailDonasiToolStripMenuItem
            // 
            this.detailDonasiToolStripMenuItem.Name = "detailDonasiToolStripMenuItem";
            this.detailDonasiToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.detailDonasiToolStripMenuItem.Text = "Detail Donasi";
            this.detailDonasiToolStripMenuItem.Click += new System.EventHandler(this.detailDonasiToolStripMenuItem_Click);
            // 
            // detailKatalogHewanToolStripMenuItem
            // 
            this.detailKatalogHewanToolStripMenuItem.Name = "detailKatalogHewanToolStripMenuItem";
            this.detailKatalogHewanToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.detailKatalogHewanToolStripMenuItem.Text = "Detail Katalog Hewan";
            this.detailKatalogHewanToolStripMenuItem.Click += new System.EventHandler(this.detailKatalogHewanToolStripMenuItem_Click);
            // 
            // generateTxtToolStripMenuItem
            // 
            this.generateTxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateKatalogHewanToolStripMenuItem,
            this.generateDetailDonasiToolStripMenuItem});
            this.generateTxtToolStripMenuItem.Name = "generateTxtToolStripMenuItem";
            this.generateTxtToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.generateTxtToolStripMenuItem.Text = "Generate txt";
            this.generateTxtToolStripMenuItem.Click += new System.EventHandler(this.generateTxtToolStripMenuItem_Click);
            // 
            // generateKatalogHewanToolStripMenuItem
            // 
            this.generateKatalogHewanToolStripMenuItem.Name = "generateKatalogHewanToolStripMenuItem";
            this.generateKatalogHewanToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.generateKatalogHewanToolStripMenuItem.Text = "Generate Katalog Hewan";
            this.generateKatalogHewanToolStripMenuItem.Click += new System.EventHandler(this.generateKatalogHewanToolStripMenuItem_Click);
            // 
            // generateDetailDonasiToolStripMenuItem
            // 
            this.generateDetailDonasiToolStripMenuItem.Name = "generateDetailDonasiToolStripMenuItem";
            this.generateDetailDonasiToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.generateDetailDonasiToolStripMenuItem.Text = "Generate Detail Donasi";
            this.generateDetailDonasiToolStripMenuItem.Click += new System.EventHandler(this.generateDetailDonasiToolStripMenuItem_Click);
            // 
            // readTxtToolStripMenuItem1
            // 
            this.readTxtToolStripMenuItem1.Name = "readTxtToolStripMenuItem1";
            this.readTxtToolStripMenuItem1.Size = new System.Drawing.Size(92, 29);
            this.readTxtToolStripMenuItem1.Text = "Read txt";
            this.readTxtToolStripMenuItem1.Click += new System.EventHandler(this.readTxtToolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 647);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project.Properties.Resources.mkmk1;
            this.pictureBox2.Location = new System.Drawing.Point(17, 571);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.snoring_paws_shelter_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 60);
            this.label4.TabIndex = 13;
            this.label4.Text = "Snoring Paws\r\nManagement System";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1190, 680);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem animalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hewanBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHewanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hewanMasukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hewanTeradopsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasilDonasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailDonasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailKatalogHewanToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem generateTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readTxtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateKatalogHewanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateDetailDonasiToolStripMenuItem;
    }
}