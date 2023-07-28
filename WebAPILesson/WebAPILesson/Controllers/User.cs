using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Controllers
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string username { get; set; }
        [Required]
        [MaxLength(50)]
        public string email { get; set; }
        [Required]
        [MaxLength(10)]
        public string phone { get; set; }
        [Required]
        [MaxLength(10)]
        public string password { get; set; }

    }
}
