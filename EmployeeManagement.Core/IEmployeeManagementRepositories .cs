using EmployeeManagement.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core
{
   public interface IEmployeeManagementRepositories
    {
        public LoginDetails login(LoginDetails loginDetails);
     
        void SaveEmployeeDetails(EmployeeDetails empDetails);

        public List<EmployeeDetails> ViewEmployeeDetails(EmployeeDetails empDetails);



        public EmployeeDetails EditEmployeeDetails(int id);

        public void DeleteEmployeeDetails(int id);

      



    }
}
