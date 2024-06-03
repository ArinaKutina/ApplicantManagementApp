using ApplicantManagementApp.DB;
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

namespace ApplicantManagementApp.Views
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idRole { get; set; }
        public RegWindow(int IdRole)
        {
            InitializeComponent();
            idRole = IdRole;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(idRole);
            Close();
            mainWindow.Show();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text != "" && Password.Password != "")
            {
                Users users = new Users()
                {
                    login = Login.Text,
                    pass = Password.Password,
                    idRole = 3
                };
                systemEntities.Users.Add(users);
                systemEntities.SaveChanges();
                MessageBox.Show("Пользователь успешно добавлен!");
                MainWindow mainWindow = new MainWindow(idRole);
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Введите данные!!!");
            }
        }
    }
}
