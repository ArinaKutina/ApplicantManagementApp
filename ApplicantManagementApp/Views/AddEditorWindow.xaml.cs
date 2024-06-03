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
    /// Логика взаимодействия для AddEditorWindow.xaml
    /// </summary>
    public partial class AddEditorWindow : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idRole {  get; set; }

        public AddEditorWindow(int IdRole)
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users()
            {
                idRole = 2,
                login = LoginBox.Text,
                pass = PassBox.Password,
                surnameUser = SurnameBox.Text,
                nameUser = NameBox.Text,
                patronimicUser = PatronimicBox.Text,
            };
            systemEntities.Users.Add(users);
            systemEntities.SaveChanges();

            MessageBox.Show("Пользователь успешно добавлен!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
