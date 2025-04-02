using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
