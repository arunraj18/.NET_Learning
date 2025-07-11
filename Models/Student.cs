using System;
namespace FirstApp.Models
{
	public class Student
	{
		
			private int Id { get; set; }

            [Required]
            [StringLength(30)]
            private string Name { get; set; }

            [EmailAddress]
            private string Email { get; set; }

            [Required]
            [DataType(DataType.Date)]
            private DateTime EnrollmentDate { get; set; }


    }
}

