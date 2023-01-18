using EmployeePayroll.Model;
using EmployeePayroll.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeRepository employee = new EmployeeRepository();
            string actual = employee.UpdateSalary();
            string Expected = "Data Updated";
            Assert.AreEqual(Expected, actual);
        }
        [TestMethod]
        public void UpdateSalary_UsingProcedure()
        {
            EmployeeRepository employee = new EmployeeRepository();
            EmployeeModel model = new EmployeeModel();
            model.Basic_Pay = 350000;
            model.Id= 4;
            string actual = employee.UpdateSalaryUsingProcedure(model);
            string Expected = "Data Updated";
            Assert.AreEqual(Expected, actual);
        }
    }
}