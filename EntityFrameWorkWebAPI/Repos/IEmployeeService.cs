using EntityFrameWorkWebAPI.Models;

namespace EntityFrameWorkWebAPI.Repos
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeList();
        public Employee GetEmployeeById(int id);
       
        public ResponseModel SaveEmployee(Employee employee);
        public ResponseModel DeleteEmployee(int id);




    }
}
