using APIDemoProject.DataAccess.Abstraction;
using APIDemoProject.DataAccess.DatabaseContext;
using APIDemoProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDemoProject.DataAccess.Repository
{
    public class EmployeeRepostiory : IEmployeeRepository
    {
        private readonly employeesApiDemoDbContext _employeesApiDemoDbContext;
        public EmployeeRepostiory(employeesApiDemoDbContext employeesApiDemoDbContext)
        {
            _employeesApiDemoDbContext = employeesApiDemoDbContext;
        }

        public Employeetb SearchByEmployeeId(int employeeId)
        {
            return _employeesApiDemoDbContext.Employeetbs.FirstOrDefault(x => x.EmployeeId == employeeId);
        }
        public List<Employeetb> FilterByDepartment(string department)
        {
            var filterData = _employeesApiDemoDbContext.Employeetbs
                                .Where(x => x.Department == department)
                                .ToList();

            return filterData;

        }

        public List<Employeetb> SortBySalary(int salary)
        {
            var filterData = _employeesApiDemoDbContext.Employeetbs
                                .Where(x => x.Salary == salary)
                                .ToList();

            return filterData;
        }
    }
}
