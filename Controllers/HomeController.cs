using EmployeeManagement.Models;
using EmployeeManagement.Models.Interfaces;
using Microsoft.AspNetCore.Mvc; // for Controller class

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        // retrieve one employee by his/her Id
        private readonly IEmployeeRespository _employeeRespository;
        #endregion

        #region Constructors
        // Constructor Injection
        public HomeController(IEmployeeRespository employeeRespository)
        // Inject interface IEmployeeRespository inside the HomeController constructor as a parameter
        {
            // pass the parameter of the Dependency Injection to _employeeRespository field.
            _employeeRespository = employeeRespository;
        }
        #endregion

        #region Action methods
        public string Index()
        {
            // Application default route
            // return _employeeRespository field - Employee name
            return _employeeRespository.GetEmployee(103).Name;
        }
        // Custom routes/actions
        public string Details()
        // string action
        {

            return "This is Details";
        }

        // JsonResult action
        public JsonResult JsonDetails()
        {
            // return data of type Employee
            Employee employee = _employeeRespository.GetEmployee(102);
            // also works: var employee = _employeeRespository.GetEmployee(102);
            return Json(employee);
        }
        public ObjectResult ObjectResultDetails()
        // Object result action
        {
            Employee employee = _employeeRespository.GetEmployee(103);
            return new ObjectResult(employee);
        }
        public ViewResult ViewResultsDetails()
        {
            // returns a view
            Employee employee = _employeeRespository.GetEmployee(101);
            return View(employee);
        }

        #endregion

    }
}
