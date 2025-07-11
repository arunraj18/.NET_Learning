using System;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
	public class Course
	{
		private int CourseId { get; set; }

		[Required]
        [StringLength(60)]
		private string CourseName { get; set; }
	}
}

