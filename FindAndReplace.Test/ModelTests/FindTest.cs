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
      Assert.AreEqual("aaa", result);
    }

    [TestMethod]
    public void Replace_ReturnsReplaceWithIfMatch_String()
    {
      string result = Find.Replace("aaa", "aaa", "ccc");
      Assert.AreEqual("ccc", result);
    }

    [TestMethod]
    public void Replace_ReturnsReplaceWithInArray_String()
    {
      string result = Find.Replace("aaabbb", "aaa", "ccc");
      Assert.AreEqual("cccbbb", result);
    }
    // Test methods will go here.

  }
}