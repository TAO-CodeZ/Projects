using System.Collections.ObjectModel;
using System.Windows;

namespace Insurance
{
    public partial class LecturerDashboard : Window
    {
        public ObservableCollection<Claim> LecturerClaims { get; set; }

        public LecturerDashboard()
        {
            InitializeComponent();
            LecturerClaims = new ObservableCollection<Claim>
            {
                new Claim { ClaimID = "C001", LecturerName = "You", Subject = "Software Development", Hours = 5, Rate = 400, Total = 2000, Status = "Pending" }
            };
            ClaimsGrid.ItemsSource = LecturerClaims;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SubjectTextBox.Text) ||
                !int.TryParse(HoursTextBox.Text, out int hours) ||
                !double.TryParse(RateTextBox.Text, out double rate))
            {
                MessageBox.Show("Please enter valid Subject, Hours and Rate.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var claim = new Claim
            {
                ClaimID = $"C{LecturerClaims.Count + 1:D3}",
                LecturerName = "You",
                Subject = SubjectTextBox.Text.Trim(),
                Hours = hours,
                Rate = rate,
                Total = hours * rate,
                Status = "Pending"
            };

            LecturerClaims.Add(claim);
            SubjectTextBox.Clear();
            HoursTextBox.Clear();
            RateTextBox.Clear();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
