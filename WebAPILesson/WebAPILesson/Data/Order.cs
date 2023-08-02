using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    public enum OrderStatus{ 
        New = 0,Payment = 1,Complete = 2,Cancel = -1 
    }
    public class Order
    {
        public int order_id { get; set; }
        public int user_id { get; set; }
        public DateTime order_date { get; set; }
        public double total_amount { get; set; }
        public OrderStatus order_status { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public ICollection<OrderItem> orderItems { get; set; }
        public User user { get; set; }
        public Order()
        {
            orderItems = new List<OrderItem>();
        }
         

    }
}
