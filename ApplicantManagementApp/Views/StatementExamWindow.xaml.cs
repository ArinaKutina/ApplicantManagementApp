using ApplicantManagementApp.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для StatementExamWindow.xaml
    /// </summary>
    public partial class StatementExamWindow : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idUser { get; set; }
        int idRole { get; set; }
        public StatementExamWindow(int IdUser, int IdRole)
        {
            InitializeComponent();
            idUser = IdUser;
            SpecialityGrid.ItemsSource = systemEntities.Speciality.ToList();
            ExamsGrid.ItemsSource = systemEntities.StatementsExams.ToList();
        }
        private void SpecialityButton_Click(object sender, RoutedEventArgs e)
        {
                var q = SpecialityGrid.SelectedItem as Speciality;
                SpecialityBox.Text = q.nameSpeciality;
        }
        private void GetStatementExam_Click(object sender, RoutedEventArgs e)
        {
            var x = systemEntities.Users.Where(p=>p.idUser == idUser).Single();
            var u = systemEntities.Speciality.Where(b=>b.nameSpeciality == SpecialityBox.Text).Single();
            StatementsExams statementsExams = new StatementsExams()
            {
                idUser = idUser,
                idSpeciality = u.idSpeciality
            };
            systemEntities.StatementsExams.Add(statementsExams);
            systemEntities.SaveChanges();
            ExamsGrid.ItemsSource = systemEntities.StatementsExams.ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var k = ExamsGrid.SelectedItem as StatementsExams;
            systemEntities.StatementsExams.Remove(k);
            systemEntities.SaveChanges();
            ExamsGrid.ItemsSource = systemEntities.StatementsExams.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            EnrolleeWindow enrolleeWindow = new EnrolleeWindow(idUser, idRole);
            enrolleeWindow.Show();
            Close();
        }
    }
}
