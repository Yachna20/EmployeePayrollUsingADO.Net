using EmployeePayroll.Repository;
using System;
namespace EmployeePayroll
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1.Create database\n2.CreateTable");
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

                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }
    }
}
             
                   
                
             
            
        
    


