using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class AccessLevel
	{
		[Key]
		public int AccessLevelId { get; set; }
		[ForeignKey("Employee")]
		public Guid EmployeeId { get; set; }
		public Employee Employee { get; set; }
		public string Level { get; set; }
		public string Description { get; set; }

	}
}