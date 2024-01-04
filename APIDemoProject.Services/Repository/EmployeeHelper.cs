using APIDemoProject.DataAccess.Abstraction;
using APIDemoProject.DataAccess.DatabaseContext;
using APIDemoProject.Model;
using APIDemoProject.Services.Abstraction;
using AutoMapper;

namespace APIDemoProject.Services.Repository
{
    public class EmployeeHelper : IEmployeeHelper
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeHelper(IEmployeeRepository employeeRepository, IMapper mapper)
        {

            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public EmployeesModel SearchByEmployeeId(int employeeId)
        {
            var result = _employeeRepository.SearchByEmployeeId(employeeId);
             return _mapper.Map<Employeetb, EmployeesModel>(result);
        }

        public List<EmployeesModel> FilterByDepartment(string department)
        {

            var result = _employeeRepository.FilterByDepartment(department);
            return _mapper.Map<List<Employeetb>, List<EmployeesModel>>(result);
        }

        public List<EmployeesModel> SortBySalary(int salary)
        {
            var result = _employeeRepository.SortBySalary(salary);
            return _mapper.Map<List<Employeetb>, List<EmployeesModel>>(result);
        }
    }
}
