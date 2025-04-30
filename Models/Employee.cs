namespace Employee_Management_System.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string EmployeeID { get; set; }  // New property for employee ID
        public string EmployeeName { get; set; }  // Renamed from EmployeeList for clarity
        public string Department { get; set; }  // Renamed from EmployeeSearch to Department

        public Employee()
        {

        }
    }
}