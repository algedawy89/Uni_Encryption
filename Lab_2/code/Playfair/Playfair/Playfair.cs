using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playfair
{
    public class Playfair
    {


        public static string EncryptPlayfair(string plaintext, string keyword)
        {
            char[,] matrix = GenerateMatrix(keyword);
            plaintext = plaintext.ToUpper().Replace("J", "I").Replace(" ", "");

            return ProcessText(plaintext, matrix, true);
        }

        public static string DecryptPlayfair(string ciphertext, string keyword)
        {
            char[,] matrix = GenerateMatrix(keyword);
             ciphertext = ciphertext.ToUpper().Replace("J", "I").Replace(" ", "");

            return ProcessText(ciphertext, matrix, false);
        }

        public static string ProcessText(string text, char[,] matrix, bool encrypt)
        {
            StringBuilder result = new StringBuilder();

            // Ensure the length of text is even by appending 'X' if needed during encryption
            if (encrypt)
            {
                for (int i = 0; i < text.Length - 1; i += 2)
                {
                    // Insert 'X' between repeated characters during encryption
                    if (text[i] == text[i + 1])
                    {
                        text = text.Insert(i + 1, "X");
                    }
                }

                // If text length is odd, append 'X' at the end
                if (text.Length % 2 != 0)
                {
                    text += "X";
                }
            }

            for (int i = 0; i < text.Length; i += 2)
            {
                char a = text[i];
                char b = text[i + 1];

                (int row1, int col1) = FindPosition(matrix, a);
                (int row2, int col2) = FindPosition(matrix, b);

                if (row1 == -1 || row2 == -1)
                {
                    throw new Exception("Invalid characters in the text.");
                }

                if (row1 == row2)
                {
                    result.Append(matrix[row1, (col1 + (encrypt ? 1 : 4)) % 5]);
                    result.Append(matrix[row2, (col2 + (encrypt ? 1 : 4)) % 5]);
                }
                else if (col1 == col2)
                {
                    result.Append(matrix[(row1 + (encrypt ? 1 : 4)) % 5, col1]);
                    result.Append(matrix[(row2 + (encrypt ? 1 : 4)) % 5, col2]);
                }
                else
                {
                    result.Append(matrix[row1, col2]);
                    result.Append(matrix[row2, col1]);
                }
            }

            if (!encrypt)
            {
                result = result.Replace("X", "");
            }

            return result.ToString();
        }



        public static char[,] GenerateMatrix(string keyword)
        {
            char[,] matrix = new char[5, 5];
            HashSet<char> usedChars = new HashSet<char>();

            // Process the keyword, removing duplicates and excluding 'J'
            foreach (char c in keyword.ToUpper())
            {
                if (!usedChars.Contains(c) && c != 'J' && c >= 'A' && c <= 'Z')
                {
                    usedChars.Add(c);
                }
            }

            // Add remaining alphabet characters, excluding 'J'
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            foreach (char c in alphabet)
            {
                if (!usedChars.Contains(c))
                {
                    usedChars.Add(c);
                }
            }

            // Fill the matrix with characters from the usedChars set
            int index = 0;
            foreach (char c in usedChars)
            {
                matrix[index / 5, index % 5] = c;
                index++;
            }

            return matrix;
        }


        //public static char[,] GenerateMatrix(string keyword)
        //{
        //    char[,] matrix = new char[5, 5];
        //    HashSet<char> usedChars = new HashSet<char>();

        //    foreach (char c in keyword)
        //    {
        //        if (!usedChars.Contains(c) && c != 'J')
        //        {
        //            usedChars.Add(c);
        //        }
        //    }

        //    string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        //    foreach (char c in alphabet)
        //    {
        //        if (!usedChars.Contains(c))
        //        {
        //            usedChars.Add(c);
        //        }
        //    }

        //    int index = 0;
        //    foreach (char c in usedChars)
        //    {
        //        matrix[index / 5, index % 5] = c;
        //        index++;
        //    }

        //    return matrix;
        //}

        public static (int, int) FindPosition(char[,] matrix, char c)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (matrix[row, col] == c)
                    {
                        return (row, col);
                    }
                }
            }

            return (-1, -1); // Return invalid position if character not found
        }



    }
}
