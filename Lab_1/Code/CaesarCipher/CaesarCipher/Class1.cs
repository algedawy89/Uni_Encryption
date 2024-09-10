using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Encryption1
{
    public class Encryript
    {

        public static void ExecuteCmd(string command)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.Start();

                  
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    MessageBox.Show(output + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static string Readpdf(string path)
        {
            string pdfPath = $"{path}";
            string content = "";
            using (PdfReader reader = new PdfReader(pdfPath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {

                    content += PdfTextExtractor.GetTextFromPage(reader, i);

                }
                
          
                



                content = ProcessMixedText(content);

                //for (int i = content.Length - 1; i >= 0; i--)
                //{

                //    re += content[i];

                //}

                return content;
            }
           
        }


        // دالة للتحقق إذا كان النص يحتوي على أحرف عربية
        public static bool IsArabic(char c)
        {
            return (c >= 0x600 && c <= 0x6FF) || (c >= 0x750 && c <= 0x77F) || (c >= 0x8A0 && c <= 0x8FF);
        }


        public static string ProcessMixedText(string input)
        {
            var result = "";
            var word = "";

            foreach (char c in input)
            {
                // إذا كانت الأحرف عربية
                if (IsArabic(c))
                {
                    word = c + word; // عكس الحروف العربية فقط
                }
                else
                {
                    // إذا كان هناك كلمة عربية تم جمعها سابقًا، أضفها إلى النتيجة
                    if (!string.IsNullOrEmpty(word))
                    {
                        result += word;
                        word = "";
                    }
                    // أضف الحروف الإنجليزية أو الرموز كما هي
                    result += c;
                }
            }

            // إضافة آخر كلمة إذا كانت عربية
            if (!string.IsNullOrEmpty(word))
            {
                result += word;
            }

            return result;
        }



        public static string ciserEncode(string text, int key,bool isDecode)
        {

            //string arabicAlphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهوي";
            //string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //int arabicLength = arabicAlphabet.Length;
            //int englishLength = englishAlphabet.Length;
            //string result = "";

            //foreach (char c in text)
            //{
            //    if (arabicAlphabet.Contains(c.ToString()))
            //    {
            //        int index = arabicAlphabet.IndexOf(c);
            //        int newIndex = (index + key) % arabicLength;
            //        if (newIndex < 0) newIndex += arabicLength;
            //        result += arabicAlphabet[newIndex];
            //    }


            //    else if (char.IsUpper(c))
            //    {

            //        int index = englishAlphabet.IndexOf(c);
            //        int newIndex = (index + key) % englishLength;
            //        if (newIndex < 0) newIndex += englishLength;
            //        result += englishAlphabet[newIndex];
            //    }

            //    else if (char.IsLower(c))
            //    {

            //        int index = englishAlphabet.ToLower().IndexOf(c);
            //        int newIndex = (index + key) % englishLength;
            //        if (newIndex < 0) newIndex += englishLength;
            //        result += englishAlphabet.ToLower()[newIndex];

            //    }

            //    else
            //    {
            //        result += c;
            //    }


            string arabicAlphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهوي";
            string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int arabicLength = arabicAlphabet.Length;
            int englishLength = englishAlphabet.Length;
            string result = "";

            if (isDecode)
            {
                key = -key;
            }

            foreach (char c in text)
            {
                if (arabicAlphabet.Contains(c.ToString()))
                {
                    int index = arabicAlphabet.IndexOf(c);
                    int newIndex = (index + key) % arabicLength;
                    if (newIndex < 0) newIndex += arabicLength;
                    result += arabicAlphabet[newIndex];
                }
                else if (char.IsUpper(c))
                {
                    int index = englishAlphabet.IndexOf(c);
                    int newIndex = (index + key) % englishLength;
                    if (newIndex < 0) newIndex += englishLength;
                    result += englishAlphabet[newIndex];
                }
                else if (char.IsLower(c))
                {
                    int index = englishAlphabet.ToLower().IndexOf(c);
                    int newIndex = (index + key) % englishLength;
                    if (newIndex < 0) newIndex += englishLength;
                    result += englishAlphabet.ToLower()[newIndex];
                }
                else
                {
                    result += c;
                }
            }
            return result;


        }
            



        public static string ciserDecode(string text, int key)
        {

            string arabicAlphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهوي";
            string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int arabicLength = arabicAlphabet.Length;
            int englishLength = englishAlphabet.Length;
            string result = "";

            foreach (char c in text)
            {
                if (arabicAlphabet.Contains(c.ToString()))
                {
                    int index = arabicAlphabet.IndexOf(c);
                    int newIndex = (index + key) % arabicLength;
                    if (newIndex < 0) newIndex -= arabicLength;
                    result += arabicAlphabet[newIndex];
                }


                else if (char.IsUpper(c))
                {

                    int index = englishAlphabet.IndexOf(c);
                    int newIndex = (index + key) % englishLength;
                    if (newIndex < 0) newIndex -= englishLength;
                    result += englishAlphabet[newIndex];
                }

                else if (char.IsLower(c))
                {

                    int index = englishAlphabet.ToLower().IndexOf(c);
                    int newIndex = (index + key) % englishLength;
                    if (newIndex < 0) newIndex -= englishLength;
                    result += englishAlphabet.ToLower()[newIndex];

                }

                else
                {
                    result += c;
                }
            }
            return result;
        }


        public static void pdfWrite(string path, string content)
        {
            Document doc = new Document();
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            PdfWriter pdfwrite = PdfWriter.GetInstance(doc, fs);
            
                doc.Open();
                doc.Add(new Paragraph(content));

                doc.Close();
            
        }



    }
}
