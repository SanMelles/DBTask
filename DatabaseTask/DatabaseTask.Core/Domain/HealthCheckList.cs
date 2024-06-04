using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class HealthCheckList
	{
		[Key]
		public int HealthCheckId { get; set; }

		[ForeignKey("Employee")]
		public Guid EmployeeId { get; set; }
		public Employee Employee { get; set; }
		public DateTime Date {  get; set; }
		public string Result { get; set; }

	}
}