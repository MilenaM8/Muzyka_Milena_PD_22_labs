using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9_WPF_
{
    public static class CaesarCipher
    {
        const string alfabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

        private static string CodeOrEncode(string text, int key) {
            string fullAlfabet = alfabet + alfabet.ToLower();
            int letterQty = fullAlfabet.Length;
            string retVal = "";

            for (int i = 0; i < text.Length; i++)
            {
                char codedChar = text[i];
                int index = fullAlfabet.IndexOf(codedChar);
                if (index < 0)
                {
                    retVal += codedChar.ToString();
                }
                else
                {
                    int codeIndex = (letterQty + index + key) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

            return retVal;
        }
        public static string Encrypt(string plainMessage, int key)
        {
            return CodeOrEncode(plainMessage, -key);
        }
        public  static string Decrypt(string encryptedMessage, int key)
        {
            return CodeOrEncode(encryptedMessage, key);
        }
    }
}
