using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadry
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string EmploymentDate { get; set; }
        public string DismissalDate { get; set; }
        public decimal EmployeeEarning { get; set; }
        public string Comments { get; set; }
    }
}
