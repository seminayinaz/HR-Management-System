using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace HRManagement.Models
{
    public class Employee
    {
        [Key]
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public string employee_surname { get; set; }
        public string employee_city { get; set; }
        public Department dpt { get; set; }

    }
}
