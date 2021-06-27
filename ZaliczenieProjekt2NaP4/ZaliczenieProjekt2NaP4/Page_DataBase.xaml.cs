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
    /// Interaction logic for Page_DataBase.xaml
    /// </summary>
    public partial class Page_DataBase : Page
    {
        wpfCrudEntities _db = new wpfCrudEntities();
        public static DataGrid datagrid;
        public Page_DataBase()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            myDataGrid.ItemsSource = _db.members.ToList();
            datagrid = myDataGrid;
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            InsertPage Ipage = new InsertPage();
            Ipage.ShowDialog();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as member).id;
            UpdatePage Upage = new UpdatePage(Id);
            Upage.ShowDialog();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as member).id;
            var deleteMember = _db.members.Where(x => x.id == Id).Single();
            _db.members.Remove(deleteMember);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.members.ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var search = _db.members.Where(x => x.name == TextBoxSearch.Text | x.surname == TextBoxSearch.Text);
            myDataGrid.ItemsSource = search.ToList();
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            myDataGrid.ItemsSource = _db.members.ToList();
           
        }
    }
}
