using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    public class CaesarCode
    {


        public static string alphabet = "abcdefghijklmnopqrstuvwxyz";


            public static int Position(char ch)
            {
                int p = -1; // Khởi tạo giá trị mặc định
                if (ch >= 'A' && ch <= 'Z')
                    p = ch - 'A';
                else if (ch >= 'a' && ch <= 'z')
                    p = ch - 'a';
                return p;
            }
        // Hàm mã hoá văn bản theo mật mã chữ cái đơn
        public static string Encrypt(string plaintext, int key)
            {
                string cipher = "";

                foreach (char ch in plaintext)
                {
                    int p = Position(ch);
                    if (p != -1)
                    {
                        int c = (p + key) % 26;
                        cipher += alphabet[c];// Mã hoá ký tự hiện tại và thêm vào chuỗi kết quả
                    }
                    else
                    {
                        cipher += ch;
                    }
                }

                return cipher;
            }

        // Hàm giải mã văn bản đã mã hoá theo mật mã chữ cái đơn
        public static string Decrypt(string plaintext, int key)
            {
                string decryp = "";
                foreach (char ch in plaintext)
                {
                    int c = Position(ch);
                        if (c != -1)
                    {
                        int p = (c - key + 26) % 26;
                        decryp += alphabet[p];// Mã hoá ký tự hiện tại và thêm vào chuỗi kết quả
                    }
                        else
                    {
                        decryp += ch;
                    }
                  
                }

                return decryp;
            }
        }
}
