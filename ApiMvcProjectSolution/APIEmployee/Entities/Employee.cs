using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APItoDbConnection.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string? FirstName { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string? LastName { get; set; }
        [Required]
        [Column(TypeName = "Char(10)")]
        public string? MobileNumber { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string? Email { get; set; }
        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? AddressLine1 { get; set; }
        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? AddressLine2 { get; set; }
        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string? PostalCode { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string? City { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string? Country { get; set; }
        [Required]
        [Column(TypeName = "Datetime")]
        public DateTime? DateOfJoining { get; set; }
    }
}
