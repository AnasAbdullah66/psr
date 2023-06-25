using Microsoft.EntityFrameworkCore;

namespace PSR.Models
{
    public enum Gender
    {
        Male=1, 
        Female=2
    }
    public class Customer
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
        public string Document { get; set; }

        // Navigation property
        //public virtual AssesmentYear AssesmentYears { get; set; }
    }

    public class AssesmentYear
    {
        public int AssesmentYearId { get; set; }
        public string? AssesmentYears { get; set; }

        //
        public virtual Customer Customer { get; set; }
    }

    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<AssesmentYear> AssesmentYears { get; set; }
    }
}
