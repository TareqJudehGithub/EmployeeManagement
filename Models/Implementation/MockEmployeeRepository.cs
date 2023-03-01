using EmployeeManagement.Models.Interfaces;

namespace EmployeeManagement.Models.Implementation
{
    public class MockEmployeeRepository : IEmployeeRespository
    {
        // List to save new employees created (saved in memory)
        private List<Employee> _employees;

        // constructor
        public MockEmployeeRepository()
        {
            // Create new instance from Employee list
            _employees = new List<Employee>()
            {
                // create a new employee
                new Employee(){Id= 101, Name="John Smith", Department="Accounting", Email = "john.smith@gmail.com"},
                new Employee(){Id= 102, Name="Sarah Adams", Department="IT", Email="sarah_a@gmail.com"},
                new Employee(){Id= 103, Name="Ali Khaled", Department="Sales", Email="khaled_1985@gmail.com"}

        };

        }
        public Employee GetEmployee(int id)
        // retrieve employees data
        {
            // return employees by ID
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }
    }
}
