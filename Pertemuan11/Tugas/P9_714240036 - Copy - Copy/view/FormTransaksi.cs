using P9_714240036.controller;
using P9_714240036.model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace P9_714240036.view
{
    public partial class FormTransaksi : Form
    {
        Transaksi transCtrl = new Transaksi();
        Barang barangCtrl = new Barang();
        string idTransaksi = "";

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load_1(object sender, EventArgs e)
        {
            tbNamaBarang.ReadOnly = true;
            tbHarga.ReadOnly = true;
            tbTotal.ReadOnly = true;

            tbNamaBarang.BackColor = SystemColors.Control;
            tbHarga.BackColor = SystemColors.Control;
            tbTotal.BackColor = SystemColors.Control;

            LoadBarang();
            TampilTransaksi();
            ResetForm();
        }

        void TampilTransaksi()
        {
            DataGridTransaksi.DataSource = transCtrl.Tampil();

            if (DataGridTransaksi.Rows.Count > 0)
            {
                DataGridTransaksi.Columns[0].HeaderText = "ID Transaksi";
                DataGridTransaksi.Columns[1].HeaderText = "ID Barang";
                DataGridTransaksi.Columns[2].HeaderText = "Nama Barang";
                DataGridTransaksi.Columns[3].HeaderText = "Harga";
                DataGridTransaksi.Columns[4].HeaderText = "Qty";
                DataGridTransaksi.Columns[5].HeaderText = "Total";

                DataGridTransaksi.Columns[3].DefaultCellStyle.Format = "Rp #,###";
                DataGridTransaksi.Columns[5].DefaultCellStyle.Format = "Rp #,###";
            }
        }

        void LoadBarang()
        {
            cbIdBarang.DataSource = barangCtrl.TampilBarang();

            cbIdBarang.DisplayMember = "id_barang"; 
            cbIdBarang.ValueMember = "id_barang";   

            cbIdBarang.SelectedIndex = -1;          
        }

        private void cbIdBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdBarang.SelectedIndex != -1)
            {
                try
                {
                    DataRowView row = (DataRowView)cbIdBarang.SelectedItem;
                    tbNamaBarang.Text = row["nama_barang"].ToString();

                    decimal harga = Convert.ToDecimal(row["harga"]);
                    tbHarga.Text = "Rp " + harga.ToString("N0");

                    HitungTotal();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Error ambil barang: " + ex.Message); 
                }
            }
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        void HitungTotal()
        {
            decimal harga = 0;
            int qty = 0;

            string hargaClean = tbHarga.Text.Replace("Rp ", "").Replace(".", "").Replace(",", "");

            decimal.TryParse(hargaClean, out harga);
            int.TryParse(tbQty.Text, out qty);

            decimal total = harga * qty;

            if (total > 0)
                tbTotal.Text = "Rp " + total.ToString("N0");
            else
                tbTotal.Text = "Rp 0";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbIdBarang.SelectedIndex == -1 || tbQty.Text == "")
            {
                MessageBox.Show("Mohon pilih barang dan isi quantity!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            {
                M_transaksi m_trans = new M_transaksi();
                m_trans.IdBarang = cbIdBarang.SelectedValue.ToString();
                m_trans.Qty = tbQty.Text;

                m_trans.Total = tbTotal.Text.Replace("Rp ", "").Replace(".", "").Replace(",", "");

                transCtrl.Insert(m_trans);
                ResetForm();
                TampilTransaksi(); 
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idTransaksi != "" && cbIdBarang.SelectedIndex != -1 && tbQty.Text != "")
            {
                M_transaksi m_trans = new M_transaksi();
                m_trans.IdTransaksi = idTransaksi;
                m_trans.IdBarang = cbIdBarang.SelectedValue.ToString();
                m_trans.Qty = tbQty.Text;
                m_trans.Total = tbTotal.Text.Replace("Rp ", "").Replace(".", "").Replace(",", "");

                transCtrl.Update(m_trans);
                ResetForm();
                TampilTransaksi();
            }
            else
            {
                MessageBox.Show("Pilih data transaksi yang akan diubah!", "Peringatan");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idTransaksi != "")
            {
                DialogResult pesan = MessageBox.Show("Apakah yakin ingin menghapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pesan == DialogResult.Yes)
                {
                    transCtrl.Delete(idTransaksi);
                    ResetForm();
                    TampilTransaksi();
                }
            }
            else
            {
                MessageBox.Show("Pilih data transaksi yang akan dihapus!", "Peringatan");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBarang();
            ResetForm();
            TampilTransaksi();
        }

        void ResetForm()
        {
            cbIdBarang.SelectedIndex = -1;
            tbNamaBarang.Text = "";
            tbHarga.Text = "";
            tbQty.Text = "";
            tbTotal.Text = "";
            tbCariData.Text = "";
            idTransaksi = "";

            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void DataGridTransaksi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTransaksi = DataGridTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();

                cbIdBarang.SelectedValue = DataGridTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();

                tbQty.Text = DataGridTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();

                btnSimpan.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        private void tbCariData_TextChanged_1(object sender, EventArgs e)
        {
            DataGridTransaksi.DataSource = transCtrl.CariData(tbCariData.Text);
        }
    }
}