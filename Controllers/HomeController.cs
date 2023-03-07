using EmployeeManagement.Models;
using EmployeeManagement.Models.Interfaces;
using Microsoft.AspNetCore.Mvc; // for Controller class

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        // retrieve one employee by his/her Id by creating an instance from IEmployeeRespository.
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
        public ViewResult Details()
        {
            Employee employee = _employeeRespository.GetEmployee(101);

            // ViewData[]
            // ViewData[] stores dictionary type data in a string format.
            ViewData["PageTitle"] = "Employee Details";
            ViewData["Employee"] = employee;

            return View(employee);


        }
        #endregion
    }
}
