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
    }
}