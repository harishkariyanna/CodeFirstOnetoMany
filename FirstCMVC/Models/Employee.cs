using System.ComponentModel.DataAnnotations;

namespace FirstCMVC.Models
{
    public class Employee
    {
        
        [Key]
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
