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
    /// Логика взаимодействия для EnrolleeWindow.xaml
    /// </summary>
    public partial class EnrolleeWindow : Window
    {
        int IdUser {  get; set; }
        int IdRole { get; set; }
        public EnrolleeWindow(int idUser, int idRole)
        {
            InitializeComponent();
            IdUser = idUser;
            IdRole = idRole;
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            StatementWindow statementWindow = new StatementWindow(IdUser, IdRole);
            statementWindow.Show();
            Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(IdRole);
            mainWindow.Show();
            Close();
        }

        private void ExamButton_Click(object sender, RoutedEventArgs e)
        {
            StatementExamWindow statementExamWindow = new StatementExamWindow(IdUser, IdRole);
            statementExamWindow.Show();
            Close();
        }

        private void RatingButton_Click(object sender, RoutedEventArgs e)
        {
            RatingWindow ratingWindow = new RatingWindow(IdUser, IdRole);
            ratingWindow.Show();
            Close();
        }
    }
}
