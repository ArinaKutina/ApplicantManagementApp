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
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        int idRole {  get; set; }
        public AddUserWindow(int IdRole)
        {
            InitializeComponent();
            idRole = IdRole;
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            AddAdminWindow addAdminWindow = new AddAdminWindow(idRole);
            addAdminWindow.Show();
            Close();
        }
        private void EditorButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditorWindow addEditorWindow = new AddEditorWindow(idRole);
            addEditorWindow.Show();
            Close();
        }

        private void EnrolleeButton_Click(object sender, RoutedEventArgs e)
        {
            AddEnrolleeWindow addEnrolleeWindow = new AddEnrolleeWindow(idRole);
            addEnrolleeWindow.Show();
            Close();
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
