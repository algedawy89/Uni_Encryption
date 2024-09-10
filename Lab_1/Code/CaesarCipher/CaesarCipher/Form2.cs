using Encryption1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) ||
                string.IsNullOrEmpty(output.Text))
            {
                MessageBox.Show("يرجى تحديد ملفات الإدخال والإخراج أولا.");
                return;
            }

            if (!int.TryParse(textkey.Text, out int key))
            {
                MessageBox.Show("يرجى إدخال مفتاح صحيح.");
                return;
            }

            string text = File.ReadAllText(txtInput.Text);

            string encryptedText = Function.CaesarCipherMixed(text, key);

            File.WriteAllText(output.Text, encryptedText);

            MessageBox.Show("تم تشفير الملف وحفظه بنجاح.");
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = openFileDialog.FileName;
                    MessageBox.Show("تم تحديد الملف: " + openFileDialog.FileName);
                }
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    output.Text = saveFileDialog.FileName;
                    MessageBox.Show("سيتم حفظ الملف في: " + output.Text);
                }
            }
        }

        private void BtnDecrype_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) ||
                string.IsNullOrEmpty(output.Text))
            {
                MessageBox.Show("يرجى تحديد ملفات الإدخال والإخراج أولا.");
                return;
            }

            if (!int.TryParse(textkey.Text, out int key))
            {
                MessageBox.Show("يرجى إدخال مفتاح صحيح.");
                return;
            }

            string text = File.ReadAllText(txtInput.Text);

            string encryptedText = Function.CaesarCipherMixed(text, -key);

            File.WriteAllText(output.Text, encryptedText);

            MessageBox.Show("تم فك تشفير الملف وحفظه بنجاح.");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog
            {
                Filter = "(txt)|*.txt|(pdf)|*.pdf",
                Title = "choose file",


            };
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = op.FileName;
                label4.Text = $"ext:{Path.GetExtension(op.FileName)} ";
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

            SaveFileDialog op = new SaveFileDialog
            {
                Filter = "(txt)|*.txt|(pdf)|*.pdf",
                Title = "choose file",


            };
            if (op.ShowDialog() == DialogResult.OK)
            {
                output.Text = op.FileName;
            }
        }

        private void BtnDe_Click(object sender, EventArgs e)
        {
            if (viewbox.Text!="") {
                richTextBox1.Text = Encryript.ciserEncode(viewbox.Text,int.Parse(textkey.Text),true);
            }

        }

        private void BtnEnFile_Click(object sender, EventArgs e)
        {
            if (viewbox.Text!=""&&textkey.Text!="") {

                richTextBox1.Text = Encryript.ciserEncode(viewbox.Text, int.Parse(textkey.Text),false);     
         
            }

            

            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void initHide(bool restAll=false) {

            if (restAll == true) {
                txtInput.Text = "";
                EncodeFileBtn.Enabled = false;
                DecodeFileBtn.Enabled=false;
            }
            textkey.Text = "";
            textkey.Enabled = false;

            output.Text = "";
            output.Enabled = false;

            viewbox.Text = "";
            viewbox.Enabled=false ;

            richTextBox1.Text = "";
            richTextBox1.Enabled = false ;

        
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim() != "" && File.Exists(txtInput.Text))
            {
                string ex = Path.GetExtension(txtInput.Text).ToLower();

                if (ex.ToLower().Contains("pdf") || ex.ToLower().Contains("txt"))
                {
                    radiopdf.Checked =(ex.Contains("pdf"))?true:false;
                    radiotxt.Checked = (ex.Contains("txt")) ? true : false;
                    

                    output.Enabled = true;
                    bool Extpdf = (Path.GetExtension(txtInput.Text).ToLower().Contains("pdf")) ? true : false;
                    string content = (Extpdf) ? Encryript.Readpdf(txtInput.Text) : File.ReadAllText(txtInput.Text);
                    viewbox.Text = content;
                }
                else {
                    MessageBox.Show("file not suport");
                    initHide(true);
                    return;
                }

            }
            else
            {
               
                initHide(false);

            }


        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            if (output.Text.Trim() != "")
            {
                textkey.Enabled = true;
            }
            

        }

        private void textkey_TextChanged(object sender, EventArgs e)
        {
            if (textkey.Text.Trim() != ""&&txtInput.Text!=""&&output.Text!="") { 
            EncodeFileBtn.Enabled=true;
            DecodeFileBtn.Enabled=true ;
            }
        }

        private void keypr(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (richTextBox1.Text.Trim() != "")
            {
                button1.Enabled = true;
            }
            else {
                button1.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (output.Text != "" && richTextBox1.Text != "")
            {
                if (radiopdf.Checked)
                {
                    Encryript.pdfWrite(output.Text, richTextBox1.Text);
                  

                }
                else if (radiotxt.Checked)
                {
                    File.WriteAllText(output.Text, richTextBox1.Text);
                }


                DialogResult r = MessageBox.Show("تم حفظ الملف بنجاح هل ترغب بفتحة؟", "done", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (File.Exists(output.Text))
                    {
                        Encryript.ExecuteCmd($"start {output.Text}");
                        button1.Enabled=false;
                        initHide(true);
                    }
                }


            }
        }
    }
}
