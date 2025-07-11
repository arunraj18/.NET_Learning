using System;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
	public class Course
	{
		public int CourseId { get; set; }

		[Required]
        [StringLength(60)]
		public string CourseName { get; set; }
	}
}

