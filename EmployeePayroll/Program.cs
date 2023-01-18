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

                Console.WriteLine("1.Create database\n2.CreateTable\n3.GetAllEmployee");
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

                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }
    }
}
             
                   
                
             
            
        
    


