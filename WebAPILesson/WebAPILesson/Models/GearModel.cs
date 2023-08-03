using System.ComponentModel.DataAnnotations;

namespace WebAPILesson.Models
{
    public class GearModel
    {
        public int gear_id { get; set; }
        public string grear_name { get; set; }
        public string description { get; set; }  
        public double price { get; set; }
        public string image_url { get; set; }
        public int quantity { get; set; }
    }
}
