using APIDemoProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDemoProject.Services.Abstraction
{
    public interface IEmployeeHelper
    {
        List<EmployeesModel> FilterByDepartment(string department);
        EmployeesModel SearchByEmployeeId(int employeeId);
        List<EmployeesModel> SortBySalary(int salary);
    }
}
