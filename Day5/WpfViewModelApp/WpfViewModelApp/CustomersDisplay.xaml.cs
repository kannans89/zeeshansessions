using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WpfViewModelApp.Business;
using WpfViewModelApp.Data.Repository;
using WpfViewModelApp.ViewModel;

namespace WpfViewModelApp
{
    /// <summary>
    /// Interaction logic for CustomersDisplay.xaml
    /// </summary>
    public partial class CustomersDisplay : Window
    {
        private ObservableCollection<CustomerVM> _customers=new ObservableCollection<CustomerVM>();
        private CustomerVM _vm = new CustomerVM();

        private CustomerRepository _repository = new CustomerRepository();
        public CustomersDisplay()
        {
            InitializeComponent();

            _vm.FirstName = "test1";
            _vm.LastName = "test2";

            _customers.Add(new CustomerVM { FirstName = "A", LastName = "B" });
           // _customers.Add(_customer);

            
            spCustomerForm.DataContext = _vm;
            this.DataContext=_customers;
        }

        private void btn_addclick(object sender, RoutedEventArgs e)
        {
            _customers.Add(new CustomerVM 
            { FirstName= _vm.FirstName,LastName=_vm.LastName } );


            var customer = new Customer();
            customer.FirstName = _vm.FirstName;
            customer.LastName = _vm.LastName;
            _repository.AddCustomer(customer);



        }

        private void updateFirstName_Click(object sender, RoutedEventArgs e)
        {
           var customer = _repository.GetByCustomerFirstName(_vm.FirstName);

            customer.LastName = _vm.LastName;
            _repository.Update(customer);

            customer.Orders.ToList();
        }
    }
}
