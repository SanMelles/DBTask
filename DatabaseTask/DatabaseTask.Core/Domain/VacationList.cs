using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class VacationList
	{
		[Key]
		public int VacationId { get; set; }

		[ForeignKey("Employee")]
		public Guid EmployeeId { get; set; }
		public Employee Employee { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

	}
}