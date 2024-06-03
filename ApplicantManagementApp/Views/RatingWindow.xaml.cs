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
    /// Логика взаимодействия для RatingWindow.xaml
    /// </summary>
    public partial class RatingWindow : Window
    {
        int idUser { get; set; }
        int idRole { get; set; }
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        public RatingWindow(int IdUser, int IdRole)
        {
            InitializeComponent();
            IdUser = idUser;
            SpecialityGrid.ItemsSource = systemEntities.Speciality.ToList();
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
            else if(idRole == 3)
            {
                EnrolleeWindow enrolleeWindow = new EnrolleeWindow(idUser, idRole);
                enrolleeWindow.Show();
                Close();
            }
        }

        private void SpecialityGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var q = SpecialityGrid.SelectedItem as Speciality;
            RatingGrid.ItemsSource = systemEntities.EnrolledUsers.Where(r => r.Speciality.nameSpeciality == q.nameSpeciality).OrderByDescending(o => o.Rate).ToList();
        }
    }
}
