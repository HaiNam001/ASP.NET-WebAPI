using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPILesson.Data
{
    public class New
    {
        public int news_id { get; set; }
      
        public string title { get; set; }
        public string content { get; set;}
       
        public DateTime publish_date { get; set; }

    }
}
