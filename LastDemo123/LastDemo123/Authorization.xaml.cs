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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(DEMOPODGOTOVKAEntities entities = new DEMOPODGOTOVKAEntities())
            {
                foreach(Users users in entities.Users)
                {
                    if(LoginBox.Text == users.login && PassBox.Text == users.password)
                    {
                        switch (users.idrole)
                        {
                            case 2:
                                ManagerWindow manager = new ManagerWindow();
                                manager.Show();
                                this.Close();
                                break;
                            default:
                                UserWindow user = new UserWindow();
                                user.Show();
                                this.Close();
                                break;
                        }
                    }
                }
            }
        }
    }
}
