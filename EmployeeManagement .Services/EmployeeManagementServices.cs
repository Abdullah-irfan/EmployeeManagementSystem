using EmployeeManagement.Core;
using EmployeeManagement.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_.Services
{
    public class EmployeeManagementServices : IEmployeeManagementServices
    {
        readonly IEmployeeManagementRepositories _employeeManagementRepositories;
        public EmployeeManagementServices(IEmployeeManagementRepositories employeeManagementRepositories)
        {
            _employeeManagementRepositories = employeeManagementRepositories;
        }
        public void DeleteEmployeeDetails(int id)
        {
            _employeeManagementRepositories.DeleteEmployeeDetails(id);
        }

        public EmployeeDetails EditEmployeeDetails(int id)
        {
            return _employeeManagementRepositories.EditEmployeeDetails(id);
        }

      

        public LoginDetails login(LoginDetails loginDetails)
        {
            return _employeeManagementRepositories.login(loginDetails);
        }

        public void SaveEmployeeDetails(EmployeeDetails empDetails)
        {
            _employeeManagementRepositories.SaveEmployeeDetails(empDetails);
        }

        public List<EmployeeDetails> ViewEmployeeDetails(EmployeeDetails empDetails)
        {
            return _employeeManagementRepositories.ViewEmployeeDetails(empDetails);
        }
    }
}
