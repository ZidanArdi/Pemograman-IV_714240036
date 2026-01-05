using MySql.Data.MySqlClient;
using P9_714240036.model;
using System;
using System.Data;
using System.Windows.Forms;

namespace P9_714240036.controller
{
    public class Transaksi
    {
        Koneksi koneksi = new Koneksi();

        public DataTable Tampil()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT t.id_transaksi, t.id_barang, b.nama_barang, b.harga, t.qty, t.total 
                         FROM t_transaksi t 
                         JOIN t_barang b ON t.id_barang = b.id_barang";

                dt = (DataTable)koneksi.ShowData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Tampil Transaksi: " + ex.Message);
            }
            return dt;
        }

        public bool CekBarangAda(string id_barang)
        {
            bool ada = false;
            try
            {
                string query = "SELECT * FROM t_transaksi WHERE id_barang = @id_barang";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@id_barang", id_barang)
                };

                DataTable dt = (DataTable)koneksi.ShowDataParam(query, parameters);
                if (dt.Rows.Count > 0) ada = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror Cek Data: " + ex.Message);
            }
            return ada;
        }

        public void Insert(M_transaksi trans)
        {
            try
            {
                koneksi.OpenConnection();
                string query = "INSERT INTO t_transaksi (id_barang, qty, total) VALUES (@id_barang, @qty, @total)";
                MySqlCommand cmd = new MySqlCommand(query);

                cmd.Parameters.AddWithValue("@id_barang", trans.IdBarang);
                cmd.Parameters.AddWithValue("@qty", trans.Qty);
                cmd.Parameters.AddWithValue("@total", trans.Total);

                koneksi.ExecuteQuery(cmd);
                koneksi.CloseConnection();
                MessageBox.Show("Data Transaksi Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menyimpan: " + ex.Message);
                koneksi.CloseConnection();
            }
        }

        public void Delete(string id_transaksi)
        {
            try
            {
                koneksi.OpenConnection();
                string query = "DELETE FROM t_transaksi WHERE id_transaksi=@id";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@id", id_transaksi);

                koneksi.ExecuteQuery(cmd);
                koneksi.CloseConnection();
                MessageBox.Show("Transaksi Berhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Hapus Transaksi: " + ex.Message);
                koneksi.CloseConnection();
            }
        }

        public DataTable CariData(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT t.id_transaksi, t.id_barang, b.nama_barang, b.harga, t.qty, t.total 
                         FROM t_transaksi t 
                         JOIN t_barang b ON t.id_barang = b.id_barang
                         WHERE b.nama_barang LIKE @keyword";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
            new MySqlParameter("@keyword", "%" + keyword + "%")
                };

                dt = (DataTable)koneksi.ShowDataParam(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Cari Data: " + ex.Message);
            }
            return dt;
        }

        public void Update(M_transaksi trans)
        {
            try
            {
                koneksi.OpenConnection();
                string query = "UPDATE t_transaksi SET id_barang = @id_barang, qty = @qty, total = @total WHERE id_transaksi = @id_transaksi";
                MySqlCommand cmd = new MySqlCommand(query);

                cmd.Parameters.AddWithValue("@id_barang", trans.IdBarang);
                cmd.Parameters.AddWithValue("@qty", trans.Qty);
                cmd.Parameters.AddWithValue("@total", trans.Total);
                cmd.Parameters.AddWithValue("@id_transaksi", trans.IdTransaksi);

                koneksi.ExecuteQuery(cmd);
                koneksi.CloseConnection();
                MessageBox.Show("Data Transaksi Berhasil Diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Mengupdate: " + ex.Message);
                koneksi.CloseConnection();
            }
        }
    }
}