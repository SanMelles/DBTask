using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class PositionList
	{
		[Key]
		public int PositionId { get; set; }
		[ForeignKey("Employee")]
		public Guid EmployeeId { get; set; }

		public string PositionName { get; set; }

		public string Description { get; set; }
		public Employee Employee { get; set; }

	}
}