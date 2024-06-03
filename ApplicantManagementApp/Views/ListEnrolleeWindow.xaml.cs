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
    /// Логика взаимодействия для ListEnrolleeWindow.xaml
    /// </summary>
    public partial class ListEnrolleeWindow : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idRole {  get; set; }
        public ListEnrolleeWindow(int IdRole)
        {
            InitializeComponent();
            EnrolleeGrid.ItemsSource = systemEntities.Users.Where(p => p.idRole == 3).ToList();
            idRole = IdRole;
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
