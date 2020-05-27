using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      TestClass obj = new TestClass();
      int a = 10, b = 20;
      int aa, bb;
      obj.SetTheValues(a, b);
      obj.GetTheValues(out aa, out bb);
      Assert.AreEqual(a, aa);
      Assert.AreEqual(b, bb);
    }
  }
}
