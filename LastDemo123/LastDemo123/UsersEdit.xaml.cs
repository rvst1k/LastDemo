using Microsoft.SqlServer.Server;
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

namespace LastDemo123
{
    /// <summary>
    /// Логика взаимодействия для UsersEdit.xaml
    /// </summary>
    public partial class UsersEdit : Window
    {
        DEMOPODGOTOVKAEntities entities1 = new DEMOPODGOTOVKAEntities();
        private Users users;
        public UsersEdit(DEMOPODGOTOVKAEntities entities, object o)
        {
            InitializeComponent();
            entities1 = entities;
            users = (o as Button).DataContext as Users;
            LoginBox.Text = users.login;
            PassBox.Text = users.password;
            NameBox.Text = users.name;
            SurnameBox.Text = users.surname;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow managerWindow = new ManagerWindow();
            managerWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            users.login = LoginBox.Text;
            users.surname = SurnameBox.Text;
            users.name = NameBox.Text;
            users.password = PassBox.Text;
            entities1.SaveChanges();
            ManagerWindow managerWindow = new ManagerWindow();
            managerWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            entities1.Users.Remove(users);
            entities1.SaveChanges();
            ManagerWindow managerWindow = new ManagerWindow();
            managerWindow.Show();
            this.Close();
        }
    }
}
