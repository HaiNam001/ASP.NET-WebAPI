using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int order_id { get; set; }

    }
}
