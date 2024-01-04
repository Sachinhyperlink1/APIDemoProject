using APIDemoProject.DataAccess.DatabaseContext;
using APIDemoProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDemoProject.DataAccess.Abstraction
{
    public interface IEmployeeRepository
    {
        List<Employeetb> FilterByDepartment(string department);
        Employeetb SearchByEmployeeId(int employeeId);
        List<Employeetb> SortBySalary(int salary);
    }
}
