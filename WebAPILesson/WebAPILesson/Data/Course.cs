using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int course_id { get; set; }
        [Required]
        [MaxLength(20)]
        public string course_name { get; set;}

        public string description { get; set;}
        [Required]       
        public string instructor { get; set; }
        [Required]
        public DateTime schedule { get; set; }
        [Required]
        public double price { get; set; }
        
    }
}
