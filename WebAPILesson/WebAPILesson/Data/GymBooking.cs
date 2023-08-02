namespace WebAPILesson.Data
{
    public class GymBooking
    {
        public int booking_id { get; set; }
        public int user_id { get; set; }
        public int gym_id { get; set; }
        public DateTime booking_date { get; set; }
        public User user { get; set; }
        public Gym gym { get; set; }
    }
}
