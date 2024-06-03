using ApplicantManagementApp.DB;
using ApplicantManagementApp.Views;
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

namespace ApplicantManagementApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int idUser { get; set; }
        int idRole { get; set; }
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        public MainWindow(int IdRole)
        {
            InitializeComponent();
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow(idRole);
            regWindow.Show();
            Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EntButton_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text != "" && Password.Password != "")
            {
                try
                {
                    var id = systemEntities.Users.Where(p => p.login == Login.Text && p.pass == Password.Password).Select(p => new { p.idUser, p.idRole }).Single();
                    if (id.idRole == 1)
                    {
                        AdminWindow adminWin = new AdminWindow(id.idRole);
                        Close();
                        adminWin.Show();
                    }
                    else if (id.idRole == 2)
                    {
                        EditorWindow editorWindow = new EditorWindow(id.idRole);
                        Close();
                        editorWindow.Show();
                    }
                    else if (id.idRole == 3)
                    {
                        EnrolleeWindow enrolleeWindow = new EnrolleeWindow(id.idUser, id.idRole);
                        Close();
                        enrolleeWindow.Show();
                    }

                    else
                    {
                        MessageBox.Show("Вы ввели неккоректные данные");
                    }
                }
                catch
                {
                    MessageBox.Show("Вы ввели неккоректные данные");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!!!");
            }
        }
    }
}
