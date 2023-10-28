using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DisposablePatternApp
{
    public class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int id)
        {
            this.Id = id;
        }
        public void Dispose()
        {
            MessageBox.Show($"I have been disposed # {Id}");
        }

        ~Clone()
        {
            MessageBox.Show($"Aaaah..you got me {this.Id}");
        }
    }
}
