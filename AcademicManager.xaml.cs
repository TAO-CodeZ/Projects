using System.Collections.ObjectModel;
using System.Windows;

namespace Insurance
{
    public partial class AcademicManager : Window
    {
        public ObservableCollection<Claim> ManagerClaims { get; set; }

        public AcademicManager()
        {
            InitializeComponent();
            ManagerClaims = new ObservableCollection<Claim>
            {
                new Claim { ClaimID = "C001", LecturerName = "Dr. Mokoena", Subject = "Computer Science", Hours = 10, Rate = 450, Total = 4500, Status = "Verified" },
                new Claim { ClaimID = "C002", LecturerName = "Ms. Zungu", Subject = "Database Design", Hours = 6, Rate = 430, Total = 2580, Status = "Verified" }
            };
            ManagerGrid.ItemsSource = ManagerClaims;
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            if (ManagerGrid.SelectedItem is Claim selected)
            {
                selected.Status = "Approved";
                ManagerGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a claim to approve.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            if (ManagerGrid.SelectedItem is Claim selected)
            {
                selected.Status = "Rejected";
                ManagerGrid.Items.Refresh();
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
