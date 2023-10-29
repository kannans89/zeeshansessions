using System;
using System.Collections.Generic;
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
using WpfViewModelApp.ViewModel;

namespace WpfViewModelApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerVM vm;
        public MainWindow()
        {
            InitializeComponent();

             vm = new CustomerVM();
            vm.FirstName = "Kanann";
            vm.LastName = "Koenig";

            this.DataContext = vm;
        }

        private void btnCheckState_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(vm.FirstName + " " + vm.LastName);
        }

        private void updateFirstName_Click(object sender, RoutedEventArgs e)
        {
            vm.FirstName = vm.FirstName + "test";

            vm.LastName = vm.LastName + "test";
            //vm.StateChanged("FirstName");

        }
    }
}
