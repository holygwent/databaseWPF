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

namespace ZaliczenieProjekt2NaP4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Uri iconUri = new Uri(@"C:\Users\48502\source\repos\ZaliczenieProjekt2NaP4\ZaliczenieProjekt2NaP4\icon1.ico", UriKind.RelativeOrAbsolute);

            this.Icon = BitmapFrame.Create(iconUri);

            InitializeComponent(); 
        }

        private void BtnDataBase(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page_DataBase();
        }

        private void BtnChart(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page_Chart();

        }
    }
}
