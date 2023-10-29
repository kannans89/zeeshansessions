using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfViewModelApp.ViewModel
{
    public class CustomerVM :INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));

                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
                }
            }
        }

        public void StateChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
