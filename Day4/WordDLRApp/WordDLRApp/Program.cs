namespace WordDLRApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var wordService = new WordDocumentService())
            {
                wordService.AddTextToDocument("Hello from dynamic language runtime! This is Zeeshan.");
                string filePath = @"c:\temp\myhelloworld.docx";
                wordService.SaveDocument(filePath);
            }

            Console.WriteLine("Document saved on c:\\temp\\. Press any key to exit.");
            Console.ReadKey();
        }
    }
}