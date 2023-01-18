using EmployeePayroll.Repository;
using System;
using EmployeePayroll.Model;

namespace EmployeePayroll
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1.Create database\n2.CreateTable\n3.GetAllEmployee\n4.UpdateSalary\n5.UpdateSalaryUsingProcedure");
                int option = Convert.ToInt32(Console.ReadLine());
                EmployeeRepository employee = new EmployeeRepository();
                switch (option)
                {
                    case 1:
                       
                        employee.CreateDatabase();
                        break;
                    case 2:
                       
                        employee.CreateTable();

                        Console.WriteLine("Table created successfully");
                       
                        break;
                    case 3:
                        EmployeeRepository.GetAllEmployee();
                        break;
                    case 4:
                        employee.UpdateSalary();
                        Console.WriteLine("Updated salary");
                        break;
                    case 5:
                        EmployeeModel model = new EmployeeModel();
                        
                        employee.UpdateSalaryUsingProcedure( model);
                        Console.WriteLine("Updated salary");
                        break;
                   
                        
                        

                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }
    }
}
             
                   
                
             
            
        
    


