using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    public class User
    {
        public int user_id { get; set; }
        
        public string username { get; set; }
       
        public string email { get; set; }
       
        public string phone { get; set; }
       
        public string password { get; set; }
        public string address { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<CourseEnrollment>courseEnrollments { get; set; }
        public ICollection<GymBooking>gymBookings { get; set; }
        public User() { 
            orders= new List<Order>();
            courseEnrollments= new List<CourseEnrollment>();
            gymBookings = new List<GymBooking>();
        }
    }
}
