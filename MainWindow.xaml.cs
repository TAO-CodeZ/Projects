using System.Windows;

namespace Insurance
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lecturer_Click(object sender, RoutedEventArgs e)
        {
            var w = new LecturerDashboard();
            w.Show();
        }

        private void Coordinator_Click(object sender, RoutedEventArgs e)
        {
            var w = new ProgrammeCoordinator();
            w.Show();
        }

        private void Manager_Click(object sender, RoutedEventArgs e)
        {
            var w = new AcademicManager();
            w.Show();
        }
    }
}
