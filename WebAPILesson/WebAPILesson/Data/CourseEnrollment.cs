namespace WebAPILesson.Data
{
    public class CourseEnrollment
    {
       public int courenroll_id { get; set; }
       public int user_id { get; set; }
       public int course_id { get; set; }
       public double price { get; set; }

       public User user { get; set; }
       public Course course { get; set; }
    }
}
