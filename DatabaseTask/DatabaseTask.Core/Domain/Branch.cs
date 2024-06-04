using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class Branch
	{
		[Key]
		public int BranchId { get; set; }

		[ForeignKey("Company")]
		public int CompanyId { get; set; }
		public Company Company { get; set; }
		public string Name { get; set; }

		public string Location { get; set; }

		public string OpeningHours { get; set; }

		public string Services { get; set; }

		public string ITInfrastructure { get; set; }

		public string SecurityMeasures { get; set; }

		public int ParkingAvailability { get; set; }

	}
}