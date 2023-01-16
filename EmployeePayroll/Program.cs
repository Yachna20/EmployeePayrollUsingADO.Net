using EmployeePayroll.Repository;
using System;
namespace EmployeePayroll
{
    public class Program
    {
        static void Main(string[] args)
        {
             {
                   
                EmployeeRepository employee = new EmployeeRepository();
                employee.CreateDatabase();
             }
            
        }
    }
}

