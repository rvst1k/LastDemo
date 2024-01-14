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
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        DEMOPODGOTOVKAEntities entities = new DEMOPODGOTOVKAEntities();
        public ManagerWindow()
        {
            InitializeComponent();
            var x = entities.Users.ToList();
            UsersGrid.ItemsSource =x;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UsersEdit usersEdit = new UsersEdit(entities, sender);
            usersEdit.Show();
            this.Close();
        }
    }
}
