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
    using System.Windows.Controls;

    public class EnterKeyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            var text = value as string;
            if (text != null)
            {
                // Perform any validation if needed
                // For now, just check if Enter key was pressed
                if (Keyboard.IsKeyDown(Key.Enter))
                {
                    return new ValidationResult(true, null);
                }
            }

            return new ValidationResult(false, "Invalid input");
        }
    }

    public partial class SimpleBinding : Window
    {
        public SimpleBinding()
        {
            InitializeComponent();


            Person p = new Person { 
             FirstName="Kannan",
             Age = 38,
             FavoriteColor="blue"
            };

            parentSp.DataContext = p;
        }

       
    }
}
