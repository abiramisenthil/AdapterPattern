using System;
using System.Collections.Generic;
using AdapterDesignPattern.Target;
using Newtonsoft.Json;

namespace AdapterDesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private EmployeeDetails _employeeDetails;

        public EmployeeAdapter(EmployeeDetails empDetails)
        {
            _employeeDetails = empDetails;
        }

        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = _employeeDetails.GetEmployees();
            foreach (string[] employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(",");
                employeeList.Add(employee[1]);
                employeeList.Add(",");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");
            }

            return employeeList;
        }
    }
}
