using DynamicTypeExamples.Models;
using System.Collections.Generic;
using System.Linq;

namespace DynamicTypeExamples.Factories
{
    public class EmployeeFactory
    {
        List<Employee> Employees { get; set; }

        public EmployeeFactory()
        {
            Employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            Employees.Add(employee);
        }

        public object GetFirstEmployee()
        {
            return Employees.FirstOrDefault();
        }
    }
}
