using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class AesExample
{
    public static string Encrypt(string textToEncrypt, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(key.PadRight(16)); // Pad the key to 128 bits (16 bytes)
            aesAlg.GenerateIV();//Inititalization Vector

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(textToEncrypt);
                    }
                }

                return Convert.ToBase64String(aesAlg.IV) + Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }

    public static string Decrypt(string textToDecrypt, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(key.PadRight(16)); // Pad the key to 128 bits (16 bytes)

            string iv = textToDecrypt.Substring(0, 24); // Extract IV from the ciphertext
            string cipherText = textToDecrypt.Substring(24); // Extract the actual ciphertext

            aesAlg.IV = Convert.FromBase64String(iv);

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }

    public static void Main()
    {
        
        string key = "Hello";
        Console.WriteLine(key.Length);
        byte[] bytes = Encoding.UTF8.GetBytes(key);
        Console.WriteLine("byte size is :" + bytes.Length);

        string originalText = "Hello Zeeshan, AES encryption!";
        string encryptedText = Encrypt(originalText, key);
        Console.WriteLine("Encrypted: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine("Decrypted: " + decryptedText);
    }
}
