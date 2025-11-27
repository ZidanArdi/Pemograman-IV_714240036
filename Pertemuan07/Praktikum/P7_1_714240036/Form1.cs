using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714240036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(457, 303);
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.AppendLine("Nama harus diisi!");
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan harus diisi!");
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage.AppendLine("Kelas harus diisi!");
            }

            string errorString = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorString))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Size = new Size(450, 598);
            }
            else
            {
                MessageBox.Show(
                    errorString.Trim(),
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekday.Checked) { 
                checkBoxKuliah.Enabled = true; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false; checkBoxLiburan.Checked = false;
            }
        }

        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekend.Checked) 
            { 
                checkBoxKuliah.Enabled = false; checkBoxKuliah.Checked = false; 
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = true; checkBoxLiburan.Checked = false;
            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string hari = "";
            string kegiatan = "";

            foreach (var control in this.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    hari = rb.Text;
                }
            }

            foreach (var control in this.Controls)
            {
                if (control is CheckBox cb && cb.Checked)
                {
                    if (kegiatan.Length > 0) kegiatan += ", ";
                    kegiatan += cb.Text;
                }
            }

            MessageBox.Show(
                $"Nama: {textBoxNama.Text}\n" +
                $"Kelas: {textBoxKelas.Text}\n" +
                $"Angkatan: {comboBoxAngkatan.Text}\n" +
                $"Hari: {hari}\n" +
                $"Kegiatan: {kegiatan}",
                "Data Anda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPrintLINQ_Click(object sender, EventArgs e)
        {
            var hari = this.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text ?? "(Tidak dipilih)";

            var kegiatan = string.Join(", ",
                this.Controls
                .OfType<CheckBox>()
                .Where(c => c.Checked)
                .Select(c => c.Text));

            MessageBox.Show(
                $"Nama: {textBoxNama.Text}\n" +
                $"Kelas: {textBoxKelas.Text}\n" +
                $"Angkatan: {comboBoxAngkatan.Text}\n" +
                $"Hari: {hari}\n" +
                $"Kegiatan: {kegiatan}",
                "Data Anda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

            MessageBox.Show(
                "Form Berhasil Direset!!",
                "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Size = new Size(457, 303);
        }
    }
}
