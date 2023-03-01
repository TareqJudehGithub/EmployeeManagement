namespace EmployeeManagement.Models.Interfaces
{
    public interface IEmployeeRespository
    {
        /**
         * This methods returns an object of type Employee
         */
        Employee GetEmployee(int id);
    }
}
