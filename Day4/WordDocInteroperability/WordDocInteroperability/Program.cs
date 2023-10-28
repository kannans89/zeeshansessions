using System;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;

namespace WordDocInteroperability
{
   
    class Program
    {
        static void Main(string[] args)
        {


            using (var wordService = new WordDocumentService())
            {
                wordService.AddTextToDocument("Hello from dynamic COM! This is a new document.");
                string filePath = @"c:\temp\MyNewDocument.docx";
                wordService.SaveDocument(filePath);
            }

            Console.WriteLine("Document saved on c:\\temp\\. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
