using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WordDLRApp
{
    public class WordDocumentService : IDisposable
    {
        private dynamic wordApp;
        private dynamic document;

        public WordDocumentService()
        {
            wordApp = Activator.CreateInstance(Type.GetTypeFromProgID("Word.Application"));
            // wordApp.Visible = true;

            document = wordApp.Documents.Add();
        }

        public void AddTextToDocument(string text)
        {
            dynamic paragraph = document.Paragraphs.Add();
            paragraph.Range.Text = text;
        }

        public void SaveDocument(string filePath)
        {
            document.SaveAs(filePath);
        }

        public void CloseAndQuit()
        {
            document.Close();
            Marshal.ReleaseComObject(document);
            Marshal.ReleaseComObject(wordApp);

        }

        public void Dispose()
        {
            CloseAndQuit();
        }
    }

}
