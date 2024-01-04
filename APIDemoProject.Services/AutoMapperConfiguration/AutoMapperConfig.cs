using APIDemoProject.DataAccess.DatabaseContext;
using APIDemoProject.Model;
using AutoMapper;

namespace APIDemoProject.Services.AutoMapperConfiguration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Employeetb, EmployeesModel>();

        }
    }
}
