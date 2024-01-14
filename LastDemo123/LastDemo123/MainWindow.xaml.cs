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

namespace LastDemo123
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(DEMOPODGOTOVKAEntities entities = new DEMOPODGOTOVKAEntities())
            {
                Users users = new Users();
                users.login = LoginBox.Text;
                users.password = PassBox.Text;
                users.name = NameBox.Text;
                users.surname = SurnameBox.Text;
                users.idrole = 3;
                entities.Users.Add(users);
                entities.SaveChanges();
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
    }
}
