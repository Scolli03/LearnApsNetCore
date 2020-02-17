using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAspNetCore.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1,Name="Shain",Department="LAY",Email="scollins@j-ldimensional.com"},
                new Employee(){Id=2,Name="Aaron",Department="LAY",Email="ascalf@j-ldimensional.com"},
                new Employee(){Id=3,Name="John",Department="LAY",Email="jholly@j-ldimensional.com"},
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
