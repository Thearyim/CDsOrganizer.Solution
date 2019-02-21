using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDsOrganizer.Models;

namespace CDsOrganizer.Tests
{
  [TestClass]
  public class CDsOrganizerTest
  {

    [TestMethod]
    public void CDsOrganizerConstructor_CreatesInstanceOfCDsOrganizer_CDsOrganizer()
    {
      CDsOrganizer newCDsOrganizer = new CDsOrganizer("test");

      Assert.AreEqual(typeof(CDsOrganizer), newCDsOrganizer.GetType());
    }

  }
}
