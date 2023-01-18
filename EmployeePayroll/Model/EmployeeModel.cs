using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Model
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        
        public string Gender { get; set; }
        public double Basic_Pay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double Net_Pay { get; set; }
    }
}
