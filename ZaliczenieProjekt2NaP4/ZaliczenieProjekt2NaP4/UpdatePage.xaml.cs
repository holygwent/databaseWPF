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
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        wpfCrudEntities _db = new wpfCrudEntities();
        int Id;
        public UpdatePage(int memberId)
        {
            Uri iconUri = new Uri(@"C:\Users\48502\source\repos\ZaliczenieProjekt2NaP4\ZaliczenieProjekt2NaP4\icon1.ico", UriKind.RelativeOrAbsolute);

            this.Icon = BitmapFrame.Create(iconUri);
            InitializeComponent();
            Id = memberId;
            TextBoxName.Text = _db.members.Where(x => x.id == Id).Single().name.ToString();
            TextBoxSurname.Text = _db.members.Where(x => x.id == Id).Single().surname.ToString();
            ComboBoxCourse.Text = _db.members.Where(x => x.id == Id).Single().course.ToString();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            member updateMember = _db.members.Where(x => x.id == Id).Single();
            updateMember.name = TextBoxName.Text;
            updateMember.surname = TextBoxSurname.Text;
            updateMember.course = ComboBoxCourse.Text;
            _db.SaveChanges();
            Page_DataBase.datagrid.ItemsSource = _db.members.ToList();
            this.Close();//or this.Hide
        }
    }
}
