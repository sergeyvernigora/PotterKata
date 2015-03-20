using NUnit.Framework;
using PotterKata.Tests.Base;

namespace PotterKata.Tests
{
    /// <summary>
    /// General tests
    /// </summary>
    [TestFixture]
    public class PotterKataTestGeneral : PotterKataTestBase
    {
        [Test]
        public void EmptyCard_Cost_Nothing()
        {
            var cost = card.GetTotal();
            Assert.AreEqual(cost, 0);
        }
    }
}
