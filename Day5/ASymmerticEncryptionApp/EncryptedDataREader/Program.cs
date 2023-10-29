using System;
using System.Text;
using System.IO;
using AsymmetricEncryption;

namespace DataEncryptionApp
{
    class Program
    {
        static void Main()
        {

            string privateKeyPath = "c:\\temp\\privateKey.xml";
            string encryptedDataPath = "c:\\temp\\encryptedData.dat";

            var rsaHelper = new RSAWithXML();

            // Read the encrypted data from the file
            byte[] encryptedData = File.ReadAllBytes(encryptedDataPath);

            // Decrypt the data with the private key
            byte[] decryptedData = rsaHelper.DecryptData(privateKeyPath, encryptedData);
            string decryptedText = Encoding.UTF8.GetString(decryptedData);

            Console.WriteLine("Decrypted data: " + decryptedText);
        }
    }
}
