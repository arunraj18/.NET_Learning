namespace FirstApp.Models
{
    public static class CourseRepository
    {
        public static List<Course> {get; set;} = new List<Course>(){
            new Course
            {
                CourseId = 1,
                CourseName = "Maths",
            }
        };


    }
}
