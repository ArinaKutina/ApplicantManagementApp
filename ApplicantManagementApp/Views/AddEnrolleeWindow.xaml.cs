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
    /// Логика взаимодействия для AddEnrolleeWindow.xaml
    /// </summary>
    public partial class AddEnrolleeWindow : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idRole {  get; set; }
        public AddEnrolleeWindow(int IdRole)
        {
            InitializeComponent();
            idRole = IdRole;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users()
            {
                idRole = 3,
                login = LoginBox.Text,
                pass = PassBox.Password,
                surnameUser = SurnameBox.Text,
                nameUser = NameBox.Text,
                patronimicUser = PatronimicBox.Text,
                telephoneNum = TelephoneBox.Text,
                passportNum = PassportBox.Text
            };
            systemEntities.Users.Add(users);
            systemEntities.SaveChanges();

            MessageBox.Show("Пользователь успешно добавлен!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (idRole == 1)
            {
                AdminWindow adminWindow = new AdminWindow(idRole);
                adminWindow.Show();
                Close();
            }
            else if (idRole == 2)
            {
                EditorWindow editorWindow = new EditorWindow(idRole);
                editorWindow.Show();
                Close();
            } 
        }
    }
}
