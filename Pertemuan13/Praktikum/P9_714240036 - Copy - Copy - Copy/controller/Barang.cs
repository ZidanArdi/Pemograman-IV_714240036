using MySql.Data.MySqlClient;
using P9_714240036.model;
using System;
using System.Data;
using System.Windows.Forms;

namespace P9_714240036.controller
{
    public class Barang
    {
        Koneksi koneksi = new Koneksi();

        public DataTable TampilBarang()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM t_barang";
                dt = (DataTable)koneksi.ShowData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data barang: " + ex.Message);
            }
            return dt;
        }

        public void Insert(M_barang m_barang)
        {
            try
            {
                koneksi.OpenConnection(); 

                string query = "INSERT INTO t_barang (nama_barang, harga) VALUES (@nama_barang, @harga)";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@nama_barang", m_barang.NamaBarang);
                cmd.Parameters.AddWithValue("@harga", m_barang.Harga);

                koneksi.ExecuteQuery(cmd); 

                koneksi.CloseConnection(); 

                MessageBox.Show("Berhasil Disimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Simpan: " + ex.Message);
                koneksi.CloseConnection();
            }
        }

        public void Update(M_barang m_barang, string id)
        {
            try
            {
                koneksi.OpenConnection();
                string query = "UPDATE t_barang SET nama_barang=@nama_barang, harga=@harga WHERE id_barang=@id";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@nama_barang", m_barang.NamaBarang);
                cmd.Parameters.AddWithValue("@harga", m_barang.Harga);
                cmd.Parameters.AddWithValue("@id", id);

                koneksi.ExecuteQuery(cmd);
                koneksi.CloseConnection();
                MessageBox.Show("Berhasil Diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Ubah: " + ex.Message);
                koneksi.CloseConnection();
            }
        }

        public void Delete(string id)
        {
            try
            {
                koneksi.OpenConnection();
                string query = "DELETE FROM t_barang WHERE id_barang=@id";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@id", id);

                koneksi.ExecuteQuery(cmd);
                koneksi.CloseConnection();
                MessageBox.Show("Berhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Hapus: " + ex.Message);
                koneksi.CloseConnection();
            }
        }

        public DataTable CariData(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM t_barang WHERE nama_barang LIKE @keyword OR harga LIKE @keyword";
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
    }
}