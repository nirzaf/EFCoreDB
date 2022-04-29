using System.ComponentModel.DataAnnotations;

namespace EFCoreDB.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

    }
}
