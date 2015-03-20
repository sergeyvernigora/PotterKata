using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PotterKata.Books;
using PotterKata.Tests.Base;

namespace PotterKata.Tests
{
    /// <summary>
    /// Test discounts on differnt books discounts (one instance of each book)
    /// </summary>
    [TestFixture]
    public class PotterKataTestDiscounts : PotterKataTestBase
    {
        [Test]
        [TestCase(PotterBooks.PotterBook1, PotterBooks.PotterBook2, Result = 15.2)]
        [TestCase(PotterBooks.PotterBook2, PotterBooks.PotterBook5, Result = 15.2)]
        [TestCase(PotterBooks.PotterBook3, PotterBooks.PotterBook4, Result = 15.2)]
        [TestCase(PotterBooks.PotterBook5, PotterBooks.PotterBook1, Result = 15.2)]
        public decimal TwoDifferentBooks_Discount5(PotterBooks book1, PotterBooks book2)
        {
            card.Add(new PotterBook(book1));
            card.Add(new PotterBook(book2));
            return card.GetTotal();
        }

        [Test]
        public void Add_Three_Different_Books_Discount10()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook3));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 21.6);
        }

        [Test]
        public void Add_Four_Different_Books_Discount15()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook3));
            card.Add(new PotterBook(PotterBooks.PotterBook4));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 27.2);
        }

        [Test]
        public void Add_Five_Different_Books_Discount20()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook3));
            card.Add(new PotterBook(PotterBooks.PotterBook4));
            card.Add(new PotterBook(PotterBooks.PotterBook5));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 32);
        }

        [Test]
        public void Add_Six_Different_Books_Discount25()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook3));
            card.Add(new PotterBook(PotterBooks.PotterBook4));
            card.Add(new PotterBook(PotterBooks.PotterBook5));
            card.Add(new PotterBook(PotterBooks.PotterBook6));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 36);
        }

        [Test]
        public void Add_Seven_Different_Books_Discount35()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook3));
            card.Add(new PotterBook(PotterBooks.PotterBook4));
            card.Add(new PotterBook(PotterBooks.PotterBook5));
            card.Add(new PotterBook(PotterBooks.PotterBook6));
            card.Add(new PotterBook(PotterBooks.PotterBook7));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 39.2);
        }
    }
}
