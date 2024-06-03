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
    /// Логика взаимодействия для StatementWindow.xaml
    /// </summary>
    public partial class StatementWindow : Window
    {
        int idUser {  get; set; }
        int idRole { get; set; }
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        public StatementWindow(int IdUser, int IdRole)
        {
            InitializeComponent();
            SpecialityGrid.ItemsSource = systemEntities.Speciality.ToList();
            idUser = IdUser;
            idRole = IdRole;
        }

        private void SpecialityButton_Click(object sender, RoutedEventArgs e)
        {
            var q = SpecialityGrid.SelectedItem as Speciality;
            SpecialityBox.Text = q.nameSpeciality; 
        }

        private void GetStatementButton_Click(object sender, RoutedEventArgs e)
        {
            var x = systemEntities.Users.Where(p=>p.idUser == idUser).Single();
            var u = systemEntities.Speciality.Where(b => b.nameSpeciality == SpecialityBox.Text).Single();
            x.surnameUser = SurnameBox.Text;
            x.nameUser = NameBox.Text;
            x.patronimicUser = PatronimicBox.Text;
            x.telephoneNum = TelephoneBox.Text;
            x.passportNum = PassportBox.Text;

            systemEntities.SaveChanges();

            MessageBox.Show("Успешно добавлено!");

            Statements statements = new Statements()
            {
                idUser = idUser,
                idStatus = 1,
                idSpeciality = u.idSpeciality, 
            };
            systemEntities.Statements.Add(statements);
            systemEntities.SaveChanges();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            EnrolleeWindow enrolleeWindow = new EnrolleeWindow(idUser, idRole);
            enrolleeWindow.Show();
            Close();
        }
    }
}
