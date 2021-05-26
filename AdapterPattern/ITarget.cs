using System.Collections.Generic;

namespace AdapterPattern
{
    public interface ITarget
    {
        void ProcessCompanySalary(List<string> employeesArray);
    }
}