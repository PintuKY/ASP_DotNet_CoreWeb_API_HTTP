using System.ComponentModel.DataAnnotations;

namespace Web_based_ticket_management_WebAPI.Model
{
    public class User
    {
        [Key] // Primary key
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;  // non-nullable

        public decimal? Salary { get; set; }       // nullable if salary can be null

        [MaxLength(150)]
        public string? College { get; set; }       // nullable

        [MaxLength(250)]
        public string? Address { get; set; }
    }
}
