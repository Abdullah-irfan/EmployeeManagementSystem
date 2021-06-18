using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Modal
{
   public class EmployeeDetails
    {
        public int EmpolyeeId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Matricule { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Gender { get; set; }
    }
}
