using CaesarCipher_Vimr.Model;

namespace CaesarCipher_Vimr.Logic
{
    public class CryptoService
    {
        public static PageContent Encrypt(string textToEncrypt, int key)
        {
            string output = string.Empty;

            if (!IsKeyValid(key))
            {
                output = "Klíč musí být větší než 0 a menší než 26!";
            }
            else
            {
                if (!string.IsNullOrEmpty(textToEncrypt))
                {
                    foreach (char c in textToEncrypt)
                        output += ShiftCharByKey(c, key);
                }
            }

            return new PageContent { 
                EncryptedText = output, 
                DecryptedText = textToEncrypt, 
                Key = key 
            };
        }

        public static PageContent Decrypt(string textToDecrypt, int key)
        {
            return new PageContent
            {
                EncryptedText = textToDecrypt,
                DecryptedText = Encrypt(textToDecrypt, 26 - key).EncryptedText,
                Key = key
            };
        }
        private static bool IsKeyValid(int key)
        {
            if (key >= 1 && key < 26)
                return true;

            return false;
        }

        private static char ShiftCharByKey(char charToShift, int key)
        {
            if (!char.IsLetter(charToShift))
                return charToShift;

            char d = char.IsUpper(charToShift) ? 'A' : 'a';
            return (char)(((charToShift + key - d) % 26) + d);
        }
    }
}
