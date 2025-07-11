using System;
using FirstApp.Models;

namespace FirstApp.Repositories
{
    public static class CourseRepository
    {
        
        static List<Course> courses = new List<Course>
        {
            new Course{

                CourseId=1,
                CourseName="Computer Science"
            },
            new Course{

                CourseId=2,
                CourseName="IT"
            }
        };
    
    }
}

