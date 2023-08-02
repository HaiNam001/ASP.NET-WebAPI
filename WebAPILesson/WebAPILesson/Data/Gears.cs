using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    [Table("Gears")]
    public class Gears
    {
        [Key]
        public int gear_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string grear_name { get; set; }
        public string description { get; set; }
        [Range(0,double.MaxValue)]
        public double price { get; set; }
        public string image_url { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public int quantity { get; set; }

        public ICollection<OrderItem> orderItems { get; set; }  
        public Gears()
        {
            orderItems = new List<OrderItem>();
        }
    }
}
