using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
	public class LoanableItem
	{
		[Key]
		public int ItemId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Availability {  get; set; }

	}
}