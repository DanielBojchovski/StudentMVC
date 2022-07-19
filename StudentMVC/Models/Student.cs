using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }

        [Required]
        public Major Major { get; set; }

        [Required]
        [Range(1.0, 5.0)]
        [Display(Name = "Grade Point Average")]
        public double GPA { get; set; }
    }
}
