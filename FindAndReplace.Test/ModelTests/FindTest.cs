using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindTest.Tests
{
  [TestClass]
  public class FindTest
  {
    
    [TestMethod]
    public void Replace_ReplaceExactMatch_String()
    {
      string result = Find.Replace("ab", "bc", "cd");
      Assert.AreEqual("false", result);
    }
    // Test methods will go here.

  }
}