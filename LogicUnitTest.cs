using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jenkins.CoreApp;

namespace Jenkins_UnitTest
{
    [TestClass]
    public class LogicUnitTest
    {
        RuleLogic onbjrulelogic = new RuleLogic();
   
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        public void Test_Add(int a, int b, int expected)
        {
            var actual = onbjrulelogic.Sumlogic(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
