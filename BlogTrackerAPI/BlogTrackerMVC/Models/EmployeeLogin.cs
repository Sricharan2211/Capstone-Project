using System.ComponentModel.DataAnnotations;

namespace BlogTrackerMVC.Models
{
    public class EmployeeLogin
    {
        [Required]
        [EmailAddress]
        public string? EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public int PassCode { get; set; }
    }
}
