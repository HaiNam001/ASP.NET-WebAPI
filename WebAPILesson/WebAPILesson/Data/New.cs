using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    [Table("News")]
    public class New
    {
        [Key]
        public int news_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string title { get; set; }
        public string content { get; set;}
        [Required]
        public DateTime publish_date { get; set; }

    }
}
