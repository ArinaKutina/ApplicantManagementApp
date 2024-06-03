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
    /// Логика взаимодействия для AddSpecialityWindow.xaml
    /// </summary>
    public partial class AddSpecialityWindow : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idRole {  get; set; }
        public AddSpecialityWindow(int IdRole)
        {
            InitializeComponent();
            idRole = IdRole;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Speciality speciality = new Speciality()
            {
                nameSpeciality = NameBox.Text
            };
            systemEntities.Speciality.Add(speciality);
            systemEntities.SaveChanges();

            MessageBox.Show("Новая специальность успешно добавлена!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow admin = new AdminWindow(idRole);
            admin.Show();
            Close();
        }
    }
}
