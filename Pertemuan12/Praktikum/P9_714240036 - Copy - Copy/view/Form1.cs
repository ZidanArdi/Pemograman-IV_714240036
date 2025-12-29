using MySql.Data.MySqlClient;
using P9_714240036.controller;
using P9_714240036.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240036
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }

        public void ResetForm()
        {
            textBoxNpm.Text = "";
            textBoxNama.Text = "";
            comboBoxAngkatan.SelectedIndex = -1;
            textBoxAlamat.Text = "";
            textBoxEmail.Text = "";
            textBoxNoHP.Text = "";
            textboxCariData.Text = "";
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNpm.Text == "" || textBoxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" || textBoxEmail.Text == "" || textBoxNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textBoxNpm.Text;
                m_mhs.Nama = textBoxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textBoxAlamat.Text;
                m_mhs.Email = textBoxEmail.Text;
                m_mhs.Nohp = textBoxNoHP.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();
            }
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            textBoxNpm.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxNoHP.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (textBoxNpm.Text == "" || textBoxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" || textBoxEmail.Text == "" || textBoxNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textBoxNpm.Text;
                m_mhs.Nama = textBoxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textBoxAlamat.Text;
                m_mhs.Email = textBoxEmail.Text;
                m_mhs.Nohp = textBoxNoHP.Text;

                mhs.Update(m_mhs, textBoxNpm.Text);

                ResetForm();
                Tampil();
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();

            MessageBox.Show("Data berhasil direfresh", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(textBoxNpm.Text);
                ResetForm();
                Tampil();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM t_mahasiswa WHERE npm LIKE @param OR nama LIKE @param";

            DataMahasiswa.DataSource = koneksi.ShowDataParam(
            sql,
            new MySqlParameter("@param", "%" + textboxCariData.Text + "%")
            );
        }
    }
}
