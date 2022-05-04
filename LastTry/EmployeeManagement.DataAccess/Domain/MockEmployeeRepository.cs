using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccess.Domain
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> employees;
        public MockEmployeeRepository()
        {
            employees = new List<Employee>()
            {
               
            };
        }
        public Employee Add(Employee employee)
        {
            employee.Id = employees.Max(x => x.Id) + 1;
            employees.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employees;
        }

        //public Employee GetEmployee(int Id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
