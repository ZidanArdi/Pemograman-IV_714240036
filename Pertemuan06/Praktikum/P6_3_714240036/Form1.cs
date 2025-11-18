using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714240036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessages(txtHuruf, "Textbox  Huruf tidak boleh kosong!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtHuruf, "", "", "Input  anda benar!");
            }
            else
            {
                SetErrorMessages(txtHuruf, "", "Input harus berupa huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, "", "", "Input  anda benar!");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Input harus berupa angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)$"))
            {
                SetErrorMessages(txtEmail, "", "", "Input  anda benar!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
                SetErrorMessages(txtAngka2, "", "", ""); 
            }
            else if (!txtAngka1.Text.All(Char.IsDigit))
            {
                SetErrorMessages(txtAngka1, "", "Input harus berupa angka!", "");
            }
            else
            {
                SetErrorMessages(txtAngka1, "", "", "Input benar!");

                if (txtAngka2.Text == "")
                {
                    SetErrorMessages(txtAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
                    SetErrorMessages(txtAngka1, "", "", "Input benar!");
                }
                else if (!txtAngka2.Text.All(Char.IsDigit))
                {
                    SetErrorMessages(txtAngka2, "", "Input harus berupa angka!", "");
                }
                else
                {
                    int angka1 = int.Parse(txtAngka1.Text);
                    int angka2 = int.Parse(txtAngka2.Text);

                    if (angka1 > angka2)
                    {
                        SetErrorMessages(txtAngka1, "", "", "Input benar!");
                        SetErrorMessages(txtAngka2, "", "", "Angka 1 lebih besar dari Angka 2");
                    }
                    else
                    {
                        string errorMessage = "Angka 1 harus lebih besar dari Angka 2";
                        SetErrorMessages(txtAngka1, "", errorMessage, "");
                        SetErrorMessages(txtAngka2, "", errorMessage, "");
                    }
                }
            }
        }
        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
                SetErrorMessages(txtAngka1, "", "", "");
            }
            else if (!txtAngka2.Text.All(Char.IsDigit))
            {
                SetErrorMessages(txtAngka2, "", "Input harus berupa angka!", "");
            }
            else
            {
                SetErrorMessages(txtAngka2, "", "", "Input benar!");

                if (txtAngka1.Text == "")
                {
                    SetErrorMessages(txtAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
                    SetErrorMessages(txtAngka2, "", "", "Input benar!");
                }
                else if (!txtAngka1.Text.All(Char.IsDigit))
                {
                    SetErrorMessages(txtAngka1, "", "Input harus berupa angka!", "");
                }
                else
                {
                    int angka1 = int.Parse(txtAngka1.Text);
                    int angka2 = int.Parse(txtAngka2.Text);

                    if (angka1 > angka2)
                    {
                        SetErrorMessages(txtAngka1, "", "", "Input benar!");
                        SetErrorMessages(txtAngka2, "", "", "Angka 1 lebih besar dari Angka 2");
                    }
                    else
                    {
                        string errorMessage = "Angka 1 harus lebih besar dari Angka 2";
                        SetErrorMessages(txtAngka1, "", errorMessage, "");
                        SetErrorMessages(txtAngka2, "", errorMessage, "");
                    }
                }
            }
        }
    }
}