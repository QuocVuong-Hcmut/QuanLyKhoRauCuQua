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

namespace Navigation_Drawer_App
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

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
           // Set tooltip visibility

            if(Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_Inputs.Visibility = Visibility.Collapsed;
                tt_outputs.Visibility = Visibility.Collapsed;
                tt_supplier.Visibility = Visibility.Collapsed;
                tt_Category.Visibility = Visibility.Collapsed;
                tt_signout.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_Inputs.Visibility = Visibility.Visible;
                tt_outputs.Visibility = Visibility.Visible;
                tt_supplier.Visibility = Visibility.Visible;
                tt_Category.Visibility = Visibility.Visible;
                tt_signout.Visibility = Visibility.Visible;
            }
        }

      

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

      
private void ListViewItem_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("xuat kho");
        }
    }
}
