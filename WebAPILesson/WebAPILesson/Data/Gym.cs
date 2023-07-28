using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    [Table("Gyms")]
    public class Gym
    {
        [Key]
        public int gym_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string gym_name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        [MaxLength(10)]
        public string phone { get; set; }
        public string website_url { get; set; }
        [MaxLength(50)]
        public string email { get; set; }
    }
}
