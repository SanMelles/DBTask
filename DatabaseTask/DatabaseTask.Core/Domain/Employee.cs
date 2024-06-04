using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<PositionList> PositionList { get; set; }
        public string Department {  get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<VacationList> Vacations { get; set; }

        public ICollection<SickLeaveList> SickLeaveList { get; set;}

        public ICollection<HealthCheckList> HealthCheckList { get; set; }

        public AccessLevel AccessLevel { get; set; }
        public Branch Branch { get; set; }
    }
}

