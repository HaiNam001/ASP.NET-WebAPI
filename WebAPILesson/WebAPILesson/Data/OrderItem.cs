namespace WebAPILesson.Data
{
    public class OrderItem
    {
        public int item_id { get; set; }
        public int order_id { get; set;}
        public int gear_id { get; set; }
        public int quantity { get; set; }
        //Relationship
        public Order order { get; set; }
        public Gears gears { get; set; }
    }
}
