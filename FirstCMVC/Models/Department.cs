using System.ComponentModel.DataAnnotations;

namespace FirstCMVC.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
