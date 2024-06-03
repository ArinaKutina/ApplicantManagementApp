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
    /// Логика взаимодействия для EditorWindow.xaml
    /// </summary>
    public partial class EditorWindow : Window
    {
        int idUser {  get; set; }
        int IdRole { get; set; }
        public EditorWindow(int idRole)
        {
            InitializeComponent();
            IdRole = idRole;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(IdRole);
            mainWindow.Show();
            Close();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            AddEnrolleeWindow addEnrolleeWindow = new AddEnrolleeWindow(IdRole);
            addEnrolleeWindow.Show();
            Close();
        }

        private void CheckUserButton_Click(object sender, RoutedEventArgs e)
        {
            ListEnrolleeWindow listEnrolleeWindow = new ListEnrolleeWindow(IdRole);
            listEnrolleeWindow.Show();
            Close();
        }

        private void StatementsButton_Click(object sender, RoutedEventArgs e)
        {
            ListStatements listStatements = new ListStatements(IdRole);
            listStatements.Show();
            Close();
        }

        private void ExamsButton_Click(object sender, RoutedEventArgs e)
        {
            ListStatementsExams listStatementsExams = new ListStatementsExams(IdRole);
            listStatementsExams.Show();
            Close();
        }

        private void ExamsGradeButton_Click(object sender, RoutedEventArgs e)
        {
            ExamsGradeWindow examsGradeWindow = new ExamsGradeWindow(IdRole);
            examsGradeWindow.Show();
            Close();
        }

        private void RatingButton_Click(object sender, RoutedEventArgs e)
        {
            RatingWindow ratingWindow = new RatingWindow(idUser, IdRole);
            ratingWindow.Show();
            Close();
        }

        private void AddSpecialityButton_Click(object sender, RoutedEventArgs e)
        {
            AddSpecialityWindow addSpecialityWindow = new AddSpecialityWindow(IdRole);
            addSpecialityWindow.Show();
            Close();
        }
    }
}
