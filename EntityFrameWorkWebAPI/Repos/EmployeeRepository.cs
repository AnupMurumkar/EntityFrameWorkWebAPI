using EntityFrameWorkWebAPI.Models;

namespace EntityFrameWorkWebAPI.Repos
{
    public class EmployeeRepository : IEmployeeService
    {
        private EmpDbContext _Context;
        public EmployeeRepository(EmpDbContext context)
        {
            _Context = context;
        }
        public List<Employee> GetEmployeeList()
        {
            List<Employee> empList;
            try
            {
                empList = _Context.Set<Employee>().ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return empList;
        }
        public Employee GetEmployeeById(int id)
        {
            Employee emp;
            try
            {
                emp = _Context.Find<Employee>(id);
            }
            catch (Exception ex)
            {
                throw;
            }
            return emp;

        }

        public ResponseModel SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public ResponseModel DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
