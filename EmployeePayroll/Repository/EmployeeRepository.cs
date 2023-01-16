using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace EmployeePayroll.Repository
{
    internal class EmployeeRepository
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AKR4CHI;Initial catalog=EmployeePayroll;
                                  Integrated Security=true");
        public void CreateDatabase()
        {
            
            SqlCommand cmd = new SqlCommand("Create database EmployeePayroll", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Database created successfully");
        }
        public void CreateTable()
        {

            SqlCommand cmd = new SqlCommand("Create table Employee(id int primary key identity(1,1),name varchar(200)," +
                "PhoneNumber bigint,Address varchar(200),Gender char,Basic_Pay bigint,Deduction bigint,Taxable_Pay bigint," +
                "Tax bigint,Net_Pay bigint,start_date date);", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            
        }


    }
}
