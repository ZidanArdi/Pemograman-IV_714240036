using P9_714240036.controller;
using P9_714240036.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240036.view
{
    public partial class FormBarang : Form
    {

        Barang barang = new Barang();
        string idBarang = "";

        public FormBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataGridBarang.DataSource = barang.TampilBarang();

            if (DataGridBarang.Rows.Count > 0)
            {
                DataGridBarang.Columns[0].HeaderText = "ID Barang";
                DataGridBarang.Columns[1].HeaderText = "Nama Barang";
                DataGridBarang.Columns[2].HeaderText = "Harga";
                DataGridBarang.Columns[2].DefaultCellStyle.Format = "Rp #,###";
            }
        }

        public void ResetForm()
        {
            tbNamaBarang.Text = "";
            tbHarga.Text = "";
            tbCariData.Text = "";
            idBarang = ""; 
            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                M_barang m_barang = new M_barang();
                m_barang.NamaBarang = tbNamaBarang.Text;

                m_barang.Harga = tbHarga.Text.Replace("Rp ", "").Replace(".", "").Replace(",", "");

                barang.Insert(m_barang);
                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idBarang != "" && tbNamaBarang.Text != "" && tbHarga.Text != "")
            {
                M_barang m_barang = new M_barang();
                m_barang.NamaBarang = tbNamaBarang.Text;

                m_barang.Harga = tbHarga.Text.Replace("Rp ", "").Replace(".", "").Replace(",", "");

                barang.Update(m_barang, idBarang);

                ResetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Pilih data tabel yang akan diubah terlebih dahulu!", "Peringatan");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idBarang != "")
            {
                DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pesan == DialogResult.Yes)
                {
                    barang.Delete(idBarang);
                    ResetForm();
                    Tampil();
                }
            }
            else
            {
                MessageBox.Show("Pilih data tabel yang akan dihapus terlebih dahulu!", "Peringatan");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void DataGridBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idBarang = DataGridBarang.Rows[e.RowIndex].Cells[0].Value.ToString();

                tbNamaBarang.Text = DataGridBarang.Rows[e.RowIndex].Cells[1].Value.ToString();

                tbHarga.Text = DataGridBarang.Rows[e.RowIndex].Cells[2].Value.ToString();

                btnSimpan.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataGridBarang.DataSource = barang.CariData(tbCariData.Text);

            if (DataGridBarang.Rows.Count > 0)
            {
                DataGridBarang.Columns[0].HeaderText = "ID Barang";
                DataGridBarang.Columns[1].HeaderText = "Nama Barang";
                DataGridBarang.Columns[2].HeaderText = "Harga";
                DataGridBarang.Columns[2].DefaultCellStyle.Format = "Rp #,###";
            }
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}
