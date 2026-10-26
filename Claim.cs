namespace Insurance
{
    public class Claim
    {
        public string ClaimID { get; set; } = string.Empty;
        public string LecturerName { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public int Hours { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
