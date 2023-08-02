using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    public class Gym
    {
        
        public int gym_id { get; set; }
       
        public string gym_name { get; set; }
        public string address { get; set; }
  
        public string phone { get; set; }
        public string website_url { get; set; }
    
        public string email { get; set; }
        public ICollection<GymBooking> gymBookings { get; set; }    
        public Gym()
        {
            gymBookings= new List<GymBooking>();
        }
    }
}
