using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp2405.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string LastName { get; set; }


        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Class")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string Class { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Subject")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int Marks { get; set; }
    }
}
