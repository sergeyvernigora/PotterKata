using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PotterKata.Card.Concrete;
using PotterKata.Card.Interface;

namespace PotterKata.Tests
{
    public class PotterKataTest
    {
        protected ICard card;

        [SetUp]
        public void TestInit()
        {
            card = new BookCard();
        }


        [Test]
        public void EmptyCard_Cost_Nothing()
        {
            var cost = card.GetTotal();
            Assert.AreEqual(cost, 0);
        }
    }
}
