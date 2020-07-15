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
    /// Interaction logic for AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        OleDbConnection con;
        DataTable dt;

        public AddProductPage()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OleDB.12.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\SampleDatabase.accdb";

        }

        private void _Reset()
        {
            textBoxProductName.Text = "";
            textBoxProductType.Text = "";
            textBoxProductPrice.Text = "";
            textBoxProductCode.Text = "";
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            _Reset();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;

            String name = textBoxProductName.Text;
            String type = textBoxProductType.Text;
            String price = textBoxProductPrice.Text;
            String code = textBoxProductCode.Text;

            cmd.CommandText = "insert into SampleTable(ProductName,ProductType,ProductPrice,ProductCode) " +
                "Values('" + name + "','" + type + "','" + price + "','" + code + "')";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Added Successfully...");
            _Reset();

        }

    }
}
