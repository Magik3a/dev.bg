using BlazorApp1;

namespace BlazorApp1TestProject.Unit
{
    [TestClass, TestCategory("Unit")]
    public class GetSiteVersionExtensionTests
    {
        [TestMethod()]
        public void GetSiteVersionTest()
        {
            var version = GetSiteVersionExtension.GetSiteVersion();
            Assert.AreEqual(version, new Version(1, 0, 0, 1));
        }
    }
}
