using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Playfair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            try
            {
                string plaintext = txtInput.Text.ToUpper().Replace("J", "I").Replace(" ", "");
                string keyword = textkey.Text.ToUpper().Replace("J", "I").Replace(" ", "");

                if (string.IsNullOrEmpty(plaintext) || string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Both the plaintext and the keyword must be provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string ciphertext =Playfair.EncryptPlayfair(plaintext, keyword);
                result.Text = ciphertext.Replace("X", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDe_Click(object sender, EventArgs e)
        {
            try
            {
                string ciphertext = txtInput.Text.ToUpper().Replace(" ", "");
                string keyword = textkey.Text.ToUpper().Replace("J", "I").Replace(" ", "");

                if (string.IsNullOrEmpty(ciphertext) || string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Both the ciphertext and the keyword must be provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string decryptedText =Playfair.DecryptPlayfair(ciphertext, keyword);
                result.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        EncFile enc=new EncFile();
        private void BtnEnFile_Click(object sender, EventArgs e)
        {
            if (enc == null || enc.IsDisposed)
            {
                enc = new EncFile();
                enc.Show();
            }
            else {
                enc.Show();

                enc.Focus();
            }
            
        }
    }
}
