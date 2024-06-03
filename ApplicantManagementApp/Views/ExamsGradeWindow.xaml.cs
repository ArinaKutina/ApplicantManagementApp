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
    /// Логика взаимодействия для ExamsGradeWindow.xaml
    /// </summary>
    public partial class ExamsGradeWindow : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idRole {  get; set; }
        public ExamsGradeWindow(int IdRole)
        {
            InitializeComponent();
            ExamGradeGrid.ItemsSource = systemEntities.EnrolledUsers.ToList();
            idRole = IdRole;
        }

        private void GreatButton_Click(object sender, RoutedEventArgs e)
        {
            var q = ExamGradeGrid.SelectedItem as EnrolledUsers;
            q.Rate = 5;
            systemEntities.SaveChanges();
            ExamGradeGrid.ItemsSource = systemEntities.EnrolledUsers.ToList();
        }

        private void GoodButton_Click(object sender, RoutedEventArgs e)
        {
            var s = ExamGradeGrid.SelectedItem as EnrolledUsers;
            s.Rate = 4;
            systemEntities.SaveChanges();
            ExamGradeGrid.ItemsSource = systemEntities.EnrolledUsers.ToList();
        }

        private void NormButton_Click(object sender, RoutedEventArgs e)
        {
            var v = ExamGradeGrid.SelectedItem as EnrolledUsers;
            v.Rate = 3;
            systemEntities.SaveChanges();
            ExamGradeGrid.ItemsSource = systemEntities.EnrolledUsers.ToList();
        }

        private void BadButton_Click(object sender, RoutedEventArgs e)
        {
            var b = ExamGradeGrid.SelectedItem as EnrolledUsers;
            b.Rate = 2;
            systemEntities.SaveChanges();
            ExamGradeGrid.ItemsSource = systemEntities.EnrolledUsers.ToList();
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
