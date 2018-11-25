using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dam
{
    public class CaesarEncryption
    {
        private static string encryptedText;
        private static string decryptedText;

        private static int key = 16;

        private static List<Char> CharList = new List<char>()
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M',
            'N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
            '0','1','2','3','4','5','6','7','8','9','9',
            '\n','~','`','!','@','#','$','%','^','&','*','(',')',
            '_','-','+','=','<','>',',','.','?','/','\\','|','[',
            ']','{','}',';',':',' '
        };

        public static string CaesarEncrypt(string input)
        {
            encryptedText = "";
            foreach (Char eChar in input.ToCharArray())
            {
                encryptedText += CharList[CharList.IndexOf(eChar) + key % CharList.Count];
            }
            return encryptedText;
        }

        public static string CaesarDecrypt(string input)
        {
            decryptedText = "";
            foreach (Char eChar in input.ToCharArray())
            {
                decryptedText += CharList[CharList.IndexOf(eChar) - key % CharList.Count];
            }
            return decryptedText;
        }
    }
}
