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
    /// Логика взаимодействия для ListStatements.xaml
    /// </summary>
    public partial class ListStatements : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idRole {  get; set; }
        public ListStatements(int IdRole)
        {
            InitializeComponent();
            StatementsGrid.ItemsSource = systemEntities.Statements.ToList();
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

        private void InProcessButton_Click(object sender, RoutedEventArgs e)
        {
            var q = StatementsGrid.SelectedItem as Statements;
            q.idStatus = 1;
            systemEntities.SaveChanges();
            StatementsGrid.ItemsSource = systemEntities.Statements.ToList();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            var t = StatementsGrid.SelectedItem as Statements;
            t.idStatus = 2;
            systemEntities.SaveChanges();
            StatementsGrid.ItemsSource = systemEntities.Statements.ToList();

            EnrolledUsers enrolledUsers = new EnrolledUsers()
            {
                idUser = t.idUser,
                idSpeciality = t.Speciality.idSpeciality
            };
            systemEntities.EnrolledUsers.Add(enrolledUsers);
            systemEntities.SaveChanges();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            var s = StatementsGrid.SelectedItem as Statements;
            s.idStatus = 3;
            systemEntities.SaveChanges();
            StatementsGrid.ItemsSource = systemEntities.Statements.ToList();
        }

        private void EnrollButton_Click(object sender, RoutedEventArgs e)
        {
            var v = StatementsGrid.SelectedItem as Statements;
            v.idStatus = 4;
            systemEntities.SaveChanges();
            StatementsGrid.ItemsSource = systemEntities.Statements.ToList();
        }
    }
}
