namespace P9_714240036.view
{
    partial class FormTransaksi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.cbIdBarang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransaksi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridTransaksi);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Transaksi Barang";
            // 
            // DataGridTransaksi
            // 
            this.DataGridTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTransaksi.Location = new System.Drawing.Point(6, 21);
            this.DataGridTransaksi.Name = "DataGridTransaksi";
            this.DataGridTransaksi.RowHeadersWidth = 51;
            this.DataGridTransaksi.RowTemplate.Height = 24;
            this.DataGridTransaksi.Size = new System.Drawing.Size(830, 270);
            this.DataGridTransaksi.TabIndex = 0;
            this.DataGridTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTransaksi_CellClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbHarga);
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.tbQty);
            this.groupBox2.Controls.Add(this.tbNamaBarang);
            this.groupBox2.Controls.Add(this.cbIdBarang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Transaksi Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rp";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(325, 112);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(161, 22);
            this.tbHarga.TabIndex = 2;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(135, 219);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(120, 22);
            this.tbTotal.TabIndex = 2;
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(135, 164);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(120, 22);
            this.tbQty.TabIndex = 2;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(135, 112);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(120, 22);
            this.tbNamaBarang.TabIndex = 2;
            // 
            // cbIdBarang
            // 
            this.cbIdBarang.FormattingEnabled = true;
            this.cbIdBarang.Location = new System.Drawing.Point(135, 32);
            this.cbIdBarang.Name = "cbIdBarang";
            this.cbIdBarang.Size = new System.Drawing.Size(250, 24);
            this.cbIdBarang.TabIndex = 1;
            this.cbIdBarang.SelectedIndexChanged += new System.EventHandler(this.cbIdBarang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Harga Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCariData);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(561, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(111, 35);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(177, 22);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.btnUbah);
            this.groupBox4.Controls.Add(this.btnSimpan);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Location = new System.Drawing.Point(561, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 165);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TomboL Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(165, 104);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(123, 34);
            this.btnHapus.TabIndex = 0;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(20, 104);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(123, 34);
            this.btnUbah.TabIndex = 0;
            this.btnUbah.Text = "Ubah ";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(165, 40);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(123, 34);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(20, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(123, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(879, 633);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransaksi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbIdBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataGridTransaksi;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
    }
}