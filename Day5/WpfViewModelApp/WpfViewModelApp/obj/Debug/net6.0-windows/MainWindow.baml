   M S B A M L   `   `   `  ����J  FWpfViewModelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfViewModelAppWpfViewModelApp  5   	        WpfViewModelApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfViewModelApp     5   	     � Title$  
MainWindow��5   	   $��30(�6   $	��450��6*   $	��800��67   .��5
      �� .+�5   
   �� $��Center=�6   Simple Customer View Model6M   �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5   
   �� Enter first name:6'   �� 5   
   -   5        $��txtFirstName��5      ��5      �� *	FirstName+ �� Mode$ TwoWay=�6;   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� Enter last name:6*   �� 5      -   5        $��txtLastName��5      ��5      �� *
LastName+$ TwoWay=�6>   5      �� 5   
   .+�5      �� -   5        $��btnCheckState��5      .��6F   
CheckState6R   �� 5      -   5        $��updateFirstName��5      .��6K   UPdate6S   5      5      5      