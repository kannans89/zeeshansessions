using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ThreadWpfApp.Services;

namespace ThreadWpfApp
{
    /// <summary>
    /// Interaction logic for MySimpleThreadWindow.xaml
    /// </summary>
    public partial class MySimpleThreadWindow : Window
    {
        private PrintingService _serivce;
        public MySimpleThreadWindow()
        {
            InitializeComponent();
           _serivce = new PrintingService();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello clicked");
        }

        private void btnPrint_click(object sender, RoutedEventArgs e)
        {
            _serivce.Print();//Blocking calls
            MessageBox.Show("end of print");
        }

        private void btnPrintThread(object sender, RoutedEventArgs e)
        {
           
            Thread thread = new Thread(() => {
                _serivce.Print();

                Debug.WriteLine("end of thread");
            });
            thread.Start(); //Non Blocking
            MessageBox.Show("end of printViaThread");
        }

        private void btnPrintViaTask(object sender, RoutedEventArgs e)
        {
            Task.Run(_serivce.Print);
            MessageBox.Show("task.run completed");
        }

        private async void btnAsync1_click(object sender, RoutedEventArgs e)
        {
            await _serivce.PrintAsync1();
            MessageBox.Show("PrintAsync1 completed");
        }

        private async void btnAsync2_click(object sender, RoutedEventArgs e)
        {
          int result = await _serivce.PrintAsync2();
            MessageBox.Show("PrintAsync2 completed"+result);
        }
    }
}
