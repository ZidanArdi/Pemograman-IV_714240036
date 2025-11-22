using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace P6_4_714240036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox9.CharacterCasing = CharacterCasing.Upper;   // Uppercase enforced
            textBox8.CharacterCasing = CharacterCasing.Lower;   // Lowercase enforced
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != textBox9.Text.ToUpper())
            {
                int cursor = textBox9.SelectionStart;
                textBox9.Text = textBox9.Text.ToUpper();
                textBox9.SelectionStart = cursor;
            }
        }

        //NUMERIC VALIDATION
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //CHAR VALIDATION
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //REQUIRED VALIDATOR
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Field Required tidak boleh kosong!");
                return;
            }

            //REGEX VALIDATOR (EMAIL)
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(textBox4.Text, pattern))
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }

            //COMPARISON VALIDATOR
            if (int.TryParse(textBox5.Text, out int angka1) &&
                int.TryParse(textBox6.Text, out int angka2))
            {
                if (angka1 <= angka2)
                {
                    MessageBox.Show("Nilai Compare1 harus LEBIH BESAR dari Compare2!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Compare harus berupa angka!");
                return;
            }

            //LENGTH VALIDATOR
            if (textBox7.Text.Length < 5)
            {
                MessageBox.Show("Text length minimal 5 karakter!");
                return;
            }

            //LOWERCASE VALIDATION
            if (textBox8.Text != textBox8.Text.ToLower())
            {
                MessageBox.Show("TextBox8 harus lowercase!");
                return;
            }

            //TAMPILAN KE MESSAGEBOX
            string output =
                " HASIL VALIDASI ISIAN FORM \n\n" +
                $"Numeric         : {textBox1.Text}\n" +
                $"Char            : {textBox2.Text}\n" +
                $"Required        : {textBox3.Text}\n" +
                $"Email (Regex)   : {textBox4.Text}\n" +
                $"Compare 1       : {textBox5.Text}\n" +
                $"Compare 2       : {textBox6.Text}\n" +
                $"Length Input    : {textBox7.Text}\n" +
                $"Uppercase Input : {textBox9.Text}\n" +
                $"Lowercase Input : {textBox8.Text}\n";

            MessageBox.Show(output, "Form Output");
        }
    }
}
