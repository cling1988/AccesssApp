using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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

namespace AccesssApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            //textBoxProductName.Text = AppDomain.CurrentDomain.BaseDirectory;
            Main.Content = new AddProductPage();
         }

        private void MenuItem_Click_Add(object sender, RoutedEventArgs e)
        {
            Main.Content = new AddProductPage();
        }

        private void MenuItem_Click_List(object sender, RoutedEventArgs e)
        {
            Main.Content = new ListProductPage();
        }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }


        
    }
}
