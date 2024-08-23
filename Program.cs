using System;


namespace Caesar
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Nhập bản rõ: ");
            string plaintext = Console.ReadLine();
            Console.Write("Nhap khoa bi mat: ");
            int key = int.Parse(Console.ReadLine());

            // Mã hoá văn bản
            string encryptedText = CaesarCode.Encrypt(plaintext, key);
            Console.WriteLine("Văn bản mã hoá: {0}", encryptedText);

            // Giải mã văn bản đã mã hoá
            string decryptedText = CaesarCode.Decrypt(encryptedText, key);
            Console.WriteLine("Văn bản giải mã: {0}", decryptedText);
        }
    }
}

    
