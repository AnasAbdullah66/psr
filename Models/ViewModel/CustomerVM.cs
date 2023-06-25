namespace PSR.Models.ViewModel
{
    public class CustomerVM
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Gender Gender { get; set; }
        public string AccountNumber { get; set; }
        public string Mobile { get; set; }
        public string BRN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AssesmentYear { get; set; }
        public string TIN { get; set; }
        public IFormFile Document { get; set; }
        public string? AssesmentYears { get; set; }

    }
}
