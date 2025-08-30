using System.ComponentModel.DataAnnotations;

namespace HRManagement.Models
{
    public class Department
    {
        [Key]
        public int department_id { get; set; }
        public string department_name { get; set; }
        public List<Employee> employees { get; set; }
    }
}
