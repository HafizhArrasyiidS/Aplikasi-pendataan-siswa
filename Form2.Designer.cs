namespace cobacoba
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btlogout = new System.Windows.Forms.Button();
            this.btnilai = new System.Windows.Forms.Button();
            this.btmapel = new System.Windows.Forms.Button();
            this.btguru = new System.Windows.Forms.Button();
            this.btsiswa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(331, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplikasi Pendataan Nilai";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 81);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnilai);
            this.panel2.Controls.Add(this.btmapel);
            this.panel2.Controls.Add(this.btguru);
            this.panel2.Controls.Add(this.btsiswa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 374);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btlogout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 320);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 54);
            this.panel5.TabIndex = 0;
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.Coral;
            this.btlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogout.Location = new System.Drawing.Point(10, 5);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(141, 46);
            this.btlogout.TabIndex = 4;
            this.btlogout.Text = "Logout";
            this.btlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btnilai
            // 
            this.btnilai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnilai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnilai.Location = new System.Drawing.Point(10, 162);
            this.btnilai.Name = "btnilai";
            this.btnilai.Size = new System.Drawing.Size(141, 46);
            this.btnilai.TabIndex = 3;
            this.btnilai.Text = "Nilai";
            this.btnilai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnilai.UseVisualStyleBackColor = false;
            this.btnilai.Click += new System.EventHandler(this.btnilai_Click);
            // 
            // btmapel
            // 
            this.btmapel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btmapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmapel.Location = new System.Drawing.Point(10, 110);
            this.btmapel.Name = "btmapel";
            this.btmapel.Size = new System.Drawing.Size(141, 46);
            this.btmapel.TabIndex = 2;
            this.btmapel.Text = "Mapel";
            this.btmapel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmapel.UseVisualStyleBackColor = false;
            this.btmapel.Click += new System.EventHandler(this.btmapel_Click);
            // 
            // btguru
            // 
            this.btguru.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btguru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btguru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguru.Location = new System.Drawing.Point(10, 58);
            this.btguru.Name = "btguru";
            this.btguru.Size = new System.Drawing.Size(141, 46);
            this.btguru.TabIndex = 1;
            this.btguru.Text = "Guru";
            this.btguru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btguru.UseVisualStyleBackColor = false;
            this.btguru.Click += new System.EventHandler(this.btguru_Click);
            // 
            // btsiswa
            // 
            this.btsiswa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btsiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsiswa.Location = new System.Drawing.Point(10, 6);
            this.btsiswa.Name = "btsiswa";
            this.btsiswa.Size = new System.Drawing.Size(141, 46);
            this.btsiswa.TabIndex = 0;
            this.btsiswa.Text = "Siswa";
            this.btsiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsiswa.UseVisualStyleBackColor = false;
            this.btsiswa.Click += new System.EventHandler(this.btsiswa_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(159, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 374);
            this.panel3.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 455);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard – Aplikasi Pendataan Nilai";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btnilai;
        private System.Windows.Forms.Button btmapel;
        private System.Windows.Forms.Button btguru;
        private System.Windows.Forms.Button btsiswa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}