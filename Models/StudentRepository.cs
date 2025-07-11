namespace FirstApp.Models
{
    public static class StudentRepository
    {
        public static List<Student> {get; set;} = new List<Student>(){
            new Student
            {
                Id = 1,
                Name = "Arun",
                Email = "Arun@gmail.com",
                EnrollmentDate = "2023, 7, 11, 15, 30, 0"
            }


        };
    }
}
