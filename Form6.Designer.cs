namespace cobacoba
{
    partial class Nilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nilai));
            this.label4 = new System.Windows.Forms.Label();
            this.cbpilihsiswa = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnilai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgnilai = new System.Windows.Forms.DataGridView();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmapel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgnilai)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(14, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nilai";
            // 
            // cbpilihsiswa
            // 
            this.cbpilihsiswa.FormattingEnabled = true;
            this.cbpilihsiswa.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cbpilihsiswa.Location = new System.Drawing.Point(120, 198);
            this.cbpilihsiswa.Name = "cbpilihsiswa";
            this.cbpilihsiswa.Size = new System.Drawing.Size(159, 21);
            this.cbpilihsiswa.TabIndex = 52;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(219, 300);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(60, 23);
            this.btCancel.TabIndex = 51;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(154, 300);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(59, 23);
            this.btDelete.TabIndex = 50;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(83, 300);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(65, 23);
            this.btUpdate.TabIndex = 49;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.DodgerBlue;
            this.btInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.ForeColor = System.Drawing.Color.White;
            this.btInsert.Location = new System.Drawing.Point(20, 300);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(57, 23);
            this.btInsert.TabIndex = 48;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(14, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mapel";
            // 
            // txtnilai
            // 
            this.txtnilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnilai.Location = new System.Drawing.Point(120, 264);
            this.txtnilai.Name = "txtnilai";
            this.txtnilai.Size = new System.Drawing.Size(159, 22);
            this.txtnilai.TabIndex = 45;
            this.txtnilai.TextChanged += new System.EventHandler(this.txtnilai_TextChanged);
            this.txtnilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnilai_KeyPress);
            this.txtnilai.Leave += new System.EventHandler(this.txtnilai_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(14, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Pilih Siswa";
            // 
            // dgnilai
            // 
            this.dgnilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnilai.Location = new System.Drawing.Point(12, 33);
            this.dgnilai.Name = "dgnilai";
            this.dgnilai.Size = new System.Drawing.Size(610, 155);
            this.dgnilai.TabIndex = 43;
            this.dgnilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgnilai_CellContentClick);
            // 
            // txtcari
            // 
            this.txtcari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcari.Location = new System.Drawing.Point(486, 5);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(136, 22);
            this.txtcari.TabIndex = 42;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(448, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cari";
            // 
            // cbmapel
            // 
            this.cbmapel.FormattingEnabled = true;
            this.cbmapel.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cbmapel.Location = new System.Drawing.Point(120, 232);
            this.cbmapel.Name = "cbmapel";
            this.cbmapel.Size = new System.Drawing.Size(159, 21);
            this.cbmapel.TabIndex = 54;
            // 
            // Nilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 335);
            this.Controls.Add(this.cbmapel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbpilihsiswa);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnilai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgnilai);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nilai";
            this.Load += new System.EventHandler(this.Nilai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgnilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbpilihsiswa;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnilai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgnilai;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmapel;
    }
}