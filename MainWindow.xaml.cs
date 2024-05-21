using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string v = "fuel.mdf";
        static string Path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        string sqconnec = @"Data Source=.;Initial Catalog=std1;Integrated Security=True;Trust Server Certificate=True";
        public MainWindow()
        {
            InitializeComponent();

            // Generate and display fixed document
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string con = @"Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\WpfApp1\WpfApp1\dl.mdf;Integrated Security=True;Trust Server Certificate=True";
                string sd = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dl.mdf;Integrated Security=True";
                    SqlConnection sql = new SqlConnection(sd);
                sql.Open();
                string q = "insert into stdtable values('" + name2.Text + "')";
                SqlCommand sc = new SqlCommand(q, sql);
                sc.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}