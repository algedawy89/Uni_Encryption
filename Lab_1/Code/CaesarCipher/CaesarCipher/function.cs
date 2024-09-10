using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Function
    {
        public static string CaesarCipherMixed(string text, int key)
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
                    if (newIndex < 0)
                        newIndex += arabicLength;
                    result += arabicAlphabet[newIndex];
                }
                else if (char.IsUpper(c))
                {
                    int index = englishAlphabet.IndexOf(c);
                    int newIndex = (index + key) % englishLength;
                    if (newIndex < 0)
                        newIndex += englishLength;
                    result += englishAlphabet[newIndex];
                }
                else if (char.IsLower(c))
                {
                    int index = englishAlphabet.ToLower().IndexOf(c);
                    int newIndex = (index + key) % englishLength;
                    if (newIndex < 0)
                        newIndex += englishLength;
                    result += englishAlphabet.ToLower()[newIndex];
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
