// See https://aka.ms/new-console-template for more information
using AsymmetricEncryption;
using System.Text;

Console.WriteLine("Hello, World!");


//RsaWithXml();

CaseSTudy1();
Console.ReadLine();

static void CaseSTudy1()
{


    string publicKeyPath = "c:\\temp\\publicKey.xml";
    string privateKeyPath = "c:\\temp\\privateKey.xml";
    string encryptedDataPath = "c:\\temp\\encryptedData.dat"; // Path to save the encrypted data

    var rsaHelper = new RSAWithXML();
    rsaHelper.AssignNewKey(publicKeyPath, privateKeyPath);

    // Encrypt data with the public key and save it to a file
    string dataToEncrypt = "Hello Zeeshan how are you asks kannan, RSA encryption!";
    byte[] encryptedData = rsaHelper.EncryptData(publicKeyPath, Encoding.UTF8.GetBytes(dataToEncrypt));

    // Save the encrypted data to a file
    File.WriteAllBytes(encryptedDataPath, encryptedData);

    Console.WriteLine("Public and private keys generated and saved.");
    Console.WriteLine("Encrypted data saved to: " + encryptedDataPath);

}

