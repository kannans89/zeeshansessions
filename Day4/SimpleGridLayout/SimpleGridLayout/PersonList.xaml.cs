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
using System.Windows.Shapes;

namespace SimpleGridLayout
{
    /// <summary>
    /// Interaction logic for PersonList.xaml
    /// </summary>
    public partial class PersonList : Window
    {
        public PersonList()
        {
            InitializeComponent();

            Person[] people = { new Person{ FirstName= "Shirley",Age= 34,FavoriteColor= "Green" },
                             new Person{ FirstName= "Shirley2",Age= 24,FavoriteColor= "Blue" },
                             };
           Cbopeople.ItemsSource= people;
         
        }
    }
}
