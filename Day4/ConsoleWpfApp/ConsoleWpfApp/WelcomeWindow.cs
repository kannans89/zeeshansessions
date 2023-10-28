using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ConsoleWpfApp
{
    public class WelcomeWindow:Window
    {
        private TextBox txt; 
        public WelcomeWindow() {

            this.Height = 300;
            this.Width = 500;
            this.Title = "Welcome to wpf says Zeeshan";

            StackPanel sp = new StackPanel();
            sp.Orientation=Orientation.Horizontal;
           
            txt = new TextBox();
            txt.Text = "enter name";
            txt.Width = 300;
            txt.Height = 30;

            Button btn = new Button();
            btn.Content = "Greet";
            btn.Width = 100;
            btn.Height = 30;
            btn.Click += CommonHandler;

            Button btn2 = new Button();
            btn2.Content = "Exit";
            btn2.Width = 100;
            btn2.Height = 30;
            btn2.Click += CommonHandler;

            sp.Children.Add(txt);
            sp.Children.Add(btn);
            sp.Children.Add(btn2);
            this.Content = sp;

        }

        private void CommonHandler(object sender, RoutedEventArgs e)
        {
     
            var source = sender as Button;
            if (source.Content.Equals("Exit")) { 
              this.Close();
                return;
            }

            MessageBox.Show("Hello mr " + txt.Text);
        }
    }
}
