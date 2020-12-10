using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindTest.Tests
{
  [TestClass]
  public class FindTest
  {
    
    [TestMethod]
    public void Replace_ReturnUserPhraseIfNoMatch_String()
    {
      string result = Find.Replace("aaa", "bbb", "ccc");
      Assert.AreEqual("bbb", result);
    }
    // Test methods will go here.

  }
}