using System;
using FirstApp.Models;

namespace FirstApp.Repositories
{
	public class StudentRepository
	{
		public StudentRepository()
		{
		}

		List<Student> students = new List<Student>
		{
			new Student{


			Id = 1,
			Name = "Sony",
			Email = "sony@gmail.com",
			EnrollmentDate = DateTime.Now
				},
			new Student
			{
			Id = 2,
			Name = "Arun",
			Email = "arun@gmail.com",
			EnrollmentDate = DateTime.Now

			}
		};
		


    }
}

