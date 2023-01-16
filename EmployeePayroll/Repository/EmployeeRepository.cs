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
        
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AKR4CHI;Initial catalog=master;
                                  Integrated Security=true");
        public void CreateDatabase()
        {
            
            SqlCommand cmd = new SqlCommand("Create database EmployeePayroll", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Database created successfully");
        }
    
    }
}
