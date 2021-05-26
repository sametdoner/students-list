using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Students.Models
{
	public class Student
	{
		public Student() // default constuctor
		{
		}

		[DisplayName("List Id")]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Surname { get; set; }
		public string Department { get; set; }
		[DataType(DataType.Date)]
		[DisplayName("Birth Date")]
		[Required]
		public DateTime BirthDate { get; set; }
		public string Height { get; set; }
		public string Weight { get; set; }
		[DataType(DataType.Date)]
		[DisplayName("Register Date")]
		public DateTime CreationDate { get; set; }
		[DataType(DataType.Date)]
		[DisplayName("Last Update Date")]
		public DateTime LastUpdateDate { get; set; }
		public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }

	}
}
