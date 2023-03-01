namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = default;
        public string Department { get; set; } = string.Empty;
        public string? Email { get; set; }
    }
}
