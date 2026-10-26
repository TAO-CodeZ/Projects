using System.Collections.ObjectModel;
using System.Windows;

namespace Insurance
{
    public partial class ProgrammeCoordinator : Window
    {
        public ObservableCollection<Claim> CoordinatorClaims { get; set; }

        public ProgrammeCoordinator()
        {
            InitializeComponent();
            CoordinatorClaims = new ObservableCollection<Claim>
            {
                new Claim { ClaimID = "C001", LecturerName = "Dr. Mokoena", Subject = "Computer Science", Hours = 10, Rate = 450, Total = 4500, Status = "Pending" },
                new Claim { ClaimID = "C002", LecturerName = "Ms. Zungu", Subject = "Database Design", Hours = 6, Rate = 430, Total = 2580, Status = "Pending" }
            };
            CoordinatorGrid.ItemsSource = CoordinatorClaims;
        }

        private void Verify_Click(object sender, RoutedEventArgs e)
        {
            if (CoordinatorGrid.SelectedItem is Claim selected)
            {
                selected.Status = "Verified";
                CoordinatorGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a claim to verify.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            if (CoordinatorGrid.SelectedItem is Claim selected)
            {
                selected.Status = "Rejected";
                CoordinatorGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a claim to reject.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
