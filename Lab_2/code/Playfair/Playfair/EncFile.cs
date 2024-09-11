using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;





namespace Playfair
{
    public partial class EncFile : Form
    {
        Dictionary<string, object> msg = new Dictionary<string, object>();
        private string filePath;

        private string fileContent;

        public EncFile()
        {
            InitializeComponent();
            msg["state"] = false;
            msg["msg"] = "";
            nonradio.Checked = true;
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf",
                Title = "Select a file to encrypt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBox1.Text = filePath;
                msg["name"] = System.IO.Path.GetFileName(filePath);
                if (filePath.EndsWith(".txt"))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                    fileContentBox.Text = fileContent;

                }
                else if (filePath.EndsWith(".pdf"))
                {
                    fileContent = ReadPdfContent(filePath);

                    fileContentBox.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("not support");
                }
            }
        }

        void btnDecrypt_click(object sender, EventArgs e)
        {
            msg["state"] = true;
            msg["msg"] = "Dectypt file";
            ProcessFile(false, txtKey.Text);
        }


        void btnEncrypt_click(object sender, EventArgs e)
        {
            msg["state"] = true;
            msg["msg"] = "Encrypt file";
            ProcessFile(true, txtKey.Text);
        }

        private void ProcessFile(bool encrypt, string key)
        {
            if (string.IsNullOrEmpty(fileContent) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please select a file and enter a key.");
                return;
            }

            string resultContent = encrypt ? Playfair.EncryptPlayfair(fileContentBox.Text.Replace("\r", ""), key) : Playfair.DecryptPlayfair(fileContentBox.Text.Replace("\r", ""), key);
            fileContent = resultContent;
            fileContentBox.Text = fileContent;
            MessageBox.Show(encrypt ? "File encrypted successfully!" : "File decrypted successfully!");
            label1.Text = encrypt ? "Encrypt" : "Decrypt";
            msg["type"] = encrypt ? "Encrypt" : "Decrypt";
        }


        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf",
                Title = "Save encrypted file"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                if (savePath.EndsWith(".txt"))
                {
                    if (MessageBox.Show("هل تريد حفظ الملف", "do", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.IO.File.WriteAllText(savePath, fileContent);
                        MessageBox.Show("تم حفظ الملف بنجاح");
                    }


                }
                else if (savePath.EndsWith(".pdf"))
                {

                    if (MessageBox.Show("هل تريد حفظ الملف", "do", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        SaveAsPdf(savePath, fileContent);
                        MessageBox.Show("تم حفظ الملف بنجاح pdf");
                    }

                }
            }
        }





        private string ReadPdfContent(string filePath)
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }
            return text.ToString();
        }

       
        private void SaveAsPdf(string savePath, string content)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(savePath, FileMode.Create));
            document.Open();

           
            Paragraph header = new Paragraph($"Playfair Cipher {msg["type"]} -> {msg["name"]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD, BaseColor.RED))
            {
                Alignment = Element.ALIGN_CENTER,
             

            };
            document.Add(header);


            document.Add(new Paragraph("\n\n"));



            iTextSharp.text.Font bodyFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.CYAN);



            PdfPTable table = new PdfPTable(1);
            table.WidthPercentage = 100;


            PdfPCell cell = new PdfPCell(new Phrase(content, bodyFont))
            {
                BorderWidth = 2,
                BorderColor = BaseColor.BLACK,
                Padding = 10,


            };

            table.AddCell(cell);


            document.Add(table);


            document.Close();

        }

        private void fileContentBox_TextChanged(object sender, EventArgs e)
        {
            // استخدام StringBuilder لبناء النص الجديد بدون الأحرف غير المرغوب فيها
            StringBuilder filteredText = new StringBuilder();

            foreach (char s in fileContentBox.Text)
            {
                // السماح فقط بالحروف الأبجدية والمسافات
                if (char.IsLetter(s) || char.IsWhiteSpace(s))
                {
                    filteredText.Append(s);
                }
            }

            // تعيين النص المفلتر إلى TextBox
            // للتحقق من عدم إعادة تعيين النص نفسه لتجنب حلقات التكرار
            if (fileContentBox.Text != filteredText.ToString())
            {
                fileContentBox.Text = filteredText.ToString();
                // تعيين موضع المؤشر إلى نهاية النص
                fileContentBox.SelectionStart = fileContentBox.Text.Length;
            }
        }

        private void EncFile_Load(object sender, EventArgs e)
        {

        }

        private void nonradio_CheckedChanged(object sender, EventArgs e)
        {
            fileContentBox.Enabled = !nonradio.Checked;
        }
    }
}
