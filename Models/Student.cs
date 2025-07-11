using System;
using System.ComponentModel.DataAnnotations;
namespace FirstApp.Models
{
	public class Student
	{
		
			public int Id { get; set; }

            [Required]
            [StringLength(30)]
            public string  Name { get; set; }

            [EmailAddress]
            public string  Email { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime EnrollmentDate { get; set; }


    }
}

