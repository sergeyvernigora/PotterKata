using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PotterKata.Tests.Base;

namespace PotterKata.Tests
{
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
