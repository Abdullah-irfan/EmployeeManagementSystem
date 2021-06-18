using EmployeeManagement.Core;
using EmployeeManagement.Core.Modal;
using EmployeeManagement_.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_.Resources
{
    public class EmployeeManagementRepositories : IEmployeeManagementRepositories
    {

        #region DeleteEmployeeDetails
        public void DeleteEmployeeDetails(int id)
        {
            EmployeeDetails employeeDeails = new EmployeeDetails();
            using (var entites = new EmployeemanagementsystemEntity())
            {
                var employeeData = entites.EmployeeManagementDetails.Where(x => x.Employee_Id == id).SingleOrDefault();
                if (employeeData != null)
                {
                    employeeData.Is_Deleted = true;
                    employeeData.Updated_Time_Stamp = DateTime.Now;
                    entites.SaveChanges();
                }
            }
        }
        #endregion


        #region EditEmployeeDetails
        public EmployeeDetails EditEmployeeDetails(int id)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            using (var entity = new EmployeemanagementsystemEntity())
            {
                var employeeDb = entity.EmployeeManagementDetails.Where(x => x.Employee_Id == id && x.Is_Deleted == false).FirstOrDefault();
                if (employeeDb != null)
                {
                    employeeDetails.EmpolyeeId = employeeDb.Employee_Id;
                    employeeDetails.FullName = employeeDb.Full_Name;
                    employeeDetails.UserName = employeeDb.User_Name;
                    employeeDetails.Email = employeeDb.Email;
                    employeeDetails.Department = employeeDb.Department;
                    employeeDetails.Matricule = employeeDb.Matricule;
                    employeeDetails.Address = employeeDb.Address;
                    employeeDetails.PhoneNumber = employeeDb.Phone_Number;
                    employeeDetails.Gender = employeeDb.Gender;
                }
                return employeeDetails;
            }
        }

        #endregion


        #region login
        public LoginDetails login(LoginDetails loginDetails)
        {
            using (EmployeemanagementsystemEntity studententity = new EmployeemanagementsystemEntity())
            {
                var logindetails = studententity.UserLoginDetails.Where(x => x.User_Name == loginDetails.UserName && x.Password == loginDetails.Password).SingleOrDefault();
                if (logindetails != null)
                {
                    return loginDetails;
                }
            }
            return null;
        }
        #endregion


        #region SaveEmployeeDetails
        public void SaveEmployeeDetails(EmployeeDetails empDetails)
        {
            EmployeeManagementDetails employee = new EmployeeManagementDetails();
            if (empDetails.EmpolyeeId == 0)
            {
                using (var entity = new EmployeemanagementsystemEntity())
                {
                    employee.Employee_Id = empDetails.EmpolyeeId;
                    employee.Full_Name = empDetails.FullName;
                    employee.User_Name = empDetails.UserName;
                    employee.Email = empDetails.Email;
                    employee.Department = empDetails.Department;
                    employee.Matricule = empDetails.Matricule;
                    employee.Address = empDetails.Address;
                    employee.Phone_Number = empDetails.PhoneNumber;
                    employee.Gender = empDetails.Gender;
                    employee.Is_Deleted = false;
                    employee.Created_Time_Stamp = DateTime.Now;
                    employee.Updated_Time_Stamp = DateTime.Now;
                    entity.EmployeeManagementDetails.Add(employee);
                    entity.SaveChanges();

                }
            }

            else
            {
                using (var entity = new EmployeemanagementsystemEntity())
                {
                    var EmployeedbData = entity.EmployeeManagementDetails.Where(x => x.Employee_Id == empDetails.EmpolyeeId && x.Is_Deleted == false).SingleOrDefault();
                    if (EmployeedbData != null)
                    {
                        EmployeedbData.Employee_Id = empDetails.EmpolyeeId;
                        EmployeedbData.Full_Name = empDetails.FullName;
                        EmployeedbData.User_Name = empDetails.UserName;
                        EmployeedbData.Department = empDetails.Department;
                        EmployeedbData.Matricule = empDetails.Matricule;
                        EmployeedbData.Address = empDetails.Address;
                        EmployeedbData.Phone_Number = empDetails.PhoneNumber;
                        EmployeedbData.Gender = empDetails.Gender;
                        EmployeedbData.Is_Deleted = false;
                        EmployeedbData.Updated_Time_Stamp = DateTime.Now;
                        entity.SaveChanges();

                    }
                }

            }
        }

        #endregion


        #region ViewEmployeeDetails
        public List<EmployeeDetails> ViewEmployeeDetails(EmployeeDetails empDetails)
        {
            List<EmployeeDetails> employeeList = new List<EmployeeDetails>();
            using (var entites = new EmployeemanagementsystemEntity())
            {
                var studentDb = entites.EmployeeManagementDetails.Where(x => x.Is_Deleted == false).ToList();
                if (studentDb != null)
                {
                    foreach (var employeeTable in studentDb)
                    {
                        EmployeeDetails employeeDetails = new EmployeeDetails();
                        employeeDetails.EmpolyeeId = employeeTable.Employee_Id;
                        employeeDetails.FullName = employeeTable.Full_Name;
                        employeeDetails.Email = employeeTable.Email;
                        employeeDetails.UserName = employeeTable.User_Name;
                        employeeDetails.Department = employeeTable.Department;
                        employeeDetails.Matricule = employeeTable.Matricule;
                        employeeDetails.Address = employeeTable.Address;
                        employeeDetails.PhoneNumber = employeeTable.Phone_Number;
                        employeeDetails.Gender = employeeTable.Gender;

                        employeeList.Add(employeeDetails);
                    }
                }
            }
            return employeeList;
        }
    }
    #endregion

}
