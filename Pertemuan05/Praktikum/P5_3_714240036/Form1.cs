using System;
using System.Windows.Forms;

namespace P5_3_714240036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";

            if (rb_android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_ios.Checked == true)
            {
                os = "IOS";
            }
            else
            {
                os = "[Belum Dipilih]";
            }

            if (cbYa.Checked == true)
            {
                status = "Ya, sudah diperbaiki";
            }
            else 
            {
                status = "Belum diperbaiki";
            }

            MessageBox.Show(
                "Merk HP: " + txtMerkHP.Text +
                "\nSistem Operasi: " + os +
                "\nStatus Perbaikan: " + status,
                "Informasi Service HP",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}