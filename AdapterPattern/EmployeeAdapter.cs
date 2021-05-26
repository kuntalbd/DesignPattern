using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(List<string> employeesArray)
        {
          
            List<Employee> listEmployee = new List<Employee>();

            foreach (var empStr in employeesArray)
            {
                var empSplit = empStr.Split(',');
                Employee emp = new Employee()
                {
                    ID = 6, 
                    Name = empSplit[1], 
                    Designation = empSplit[2], 
                    Salary = Convert.ToDecimal(empSplit[3])

                };
                listEmployee.Add(emp);
            }
            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
}