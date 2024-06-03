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
    /// Логика взаимодействия для ListStatementsExams.xaml
    /// </summary>
    public partial class ListStatementsExams : Window
    {
        ApplicantManagementSystemEntities systemEntities = new ApplicantManagementSystemEntities();
        int idRole {  get; set; }
        public ListStatementsExams(int IdRole)
        {
            InitializeComponent();
            ExamsGrid.ItemsSource = systemEntities.StatementsExams.ToList();
            idRole = IdRole;
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
