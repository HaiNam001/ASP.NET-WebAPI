using System.ComponentModel.DataAnnotations;

namespace WebAPILesson.Models
{
    public class GearModel
    {
        [Required]
        [MaxLength(50)]
        public string grear_name { get; set; }
        public string description { get; set; }
        [Range(0, double.MaxValue)]
        public double price { get; set; }
        public string image_url { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int quantity { get; set; }
    }
}
