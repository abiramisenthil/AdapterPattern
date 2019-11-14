using System;
using System.Collections.Generic;
using AdapterDesignPattern.Adapter;
using AdapterDesignPattern.Target;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Client needs Employee details in list format. The existing class(employeeDetails) method GetEmployees returns employeedetails in array of string
            So the existing class is incompatible to satisfy client request.

            */
            ITarget emp = new EmployeeAdapter(new EmployeeDetails());
            List<string> emplist = emp.GetEmployeeList();
            foreach (var item in emplist)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
