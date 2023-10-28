using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DisposablePatternApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_click(object sender, RoutedEventArgs e)
        {
          
            using (Clone c = new Clone(101)) {

            }

            //Clone c = new Clone(101);
            //c.Dispose();

            MessageBox.Show("end of btn1_click");
        }

        private void btn2_click(object sender, RoutedEventArgs e)
        {
            Clone c = new Clone(102);
            c = null;
            MessageBox.Show("end of btn2_click");
        }

        private void btn3_click(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            MessageBox.Show("Gc.Collect");
        }
    }
}
