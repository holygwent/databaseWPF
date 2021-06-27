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

namespace ZaliczenieProjekt2NaP4
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        wpfCrudEntities _db = new wpfCrudEntities();
        public InsertPage()
        {
            Uri iconUri = new Uri(@"C:\Users\48502\source\repos\ZaliczenieProjekt2NaP4\ZaliczenieProjekt2NaP4\icon1.ico", UriKind.RelativeOrAbsolute);

            this.Icon = BitmapFrame.Create(iconUri);
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            member newMember = new member()
            {
                name = TextBoxName.Text,
                surname = TextBoxSurname.Text,
                course = ComboBoxCourse.Text

            };
            _db.members.Add(newMember);
            _db.SaveChanges();
            Page_DataBase.datagrid.ItemsSource = _db.members.ToList();
            this.Close();//or this.Hide();
        }
    }
}
