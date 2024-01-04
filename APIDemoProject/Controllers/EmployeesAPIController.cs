using APIDemoProject.Models.Common;
using APIDemoProject.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemoProject.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class EmployeesAPIController : ControllerBase
    {
        private readonly IEmployeeHelper _employeeHelper;
        public EmployeesAPIController(IEmployeeHelper employeeHelper)
        {
            _employeeHelper = employeeHelper;

        }

        //1. Create a API to filter by department.
        [Route("employee/FilterByDepartment")]
        [HttpGet]
        public IActionResult FilterByDepartment()
        {
            Response response = new Response();
            try
            {
                var department = "HR";
                var userdata = _employeeHelper.FilterByDepartment(department);
                if (userdata == null)
                {
                    response.code = StatusCodes.Status404NotFound;
                    response.status = false;
                    response.message = "Data Not Found";
                    return NotFound(response);
                }
                else
                {
                    response.code = StatusCodes.Status200OK;
                    response.status = true;
                    response.message = "Success";
                    response.data = userdata;
                    return Ok(response);
                }
            }
            catch (Exception e)
            {
                response.code = StatusCodes.Status500InternalServerError;
                response.status = false;
                response.message = "Something went wrong. " + e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        //2. Create a API to sort by salary.
        [Route("employee/SortBySalary")]
        [HttpGet]
        public IActionResult SortBySalary()
        {
            Response response = new Response();
            try
            {
                var salary = 10000;
                var userdata = _employeeHelper.SortBySalary(salary);
                if (userdata == null)
                {
                    response.code = StatusCodes.Status404NotFound;
                    response.status = false;
                    response.message = "Data Not Found";
                    return NotFound(response);
                }
                else
                {
                    response.code = StatusCodes.Status200OK;
                    response.status = true;
                    response.message = "Success";
                    response.data = userdata;
                    return Ok(response);
                }
            }
            catch (Exception e)
            {
                response.code = StatusCodes.Status500InternalServerError;
                response.status = false;
                response.message = "Something went wrong. " + e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        //3. Create a API to search by employee_id.
        [Route("employee/SearchByEmployeeId{employeeId}")]
        [HttpGet]
        public IActionResult SearchByEmployeeId(int employeeId)
        {
            Response response = new Response();
            try
            {

                var userdata = _employeeHelper.SearchByEmployeeId(employeeId);
                if (userdata == null)
                {
                    response.code = StatusCodes.Status404NotFound;
                    response.status = false;
                    response.message = "Data Not Found";
                    return NotFound(response);
                }
                else
                {
                    response.code = StatusCodes.Status200OK;
                    response.status = true;
                    response.message = "Success";
                    response.data = userdata;
                    return Ok(response);
                }
            }
            catch (Exception e)
            {
                response.code = StatusCodes.Status500InternalServerError;
                response.status = false;
                response.message = "Something went wrong. " + e.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }


    }
}
