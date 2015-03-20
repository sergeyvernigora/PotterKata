using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PotterKata.Books;
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


        [Test]
        [TestCase(PotterBooks.PotterBook1, Result = 8)]
        [TestCase(PotterBooks.PotterBook2, Result = 8)]
        [TestCase(PotterBooks.PotterBook3, Result = 8)]
        [TestCase(PotterBooks.PotterBook4, Result = 8)]
        [TestCase(PotterBooks.PotterBook5, Result = 8)]
        [TestCase(PotterBooks.PotterBook6, Result = 8)]
        [TestCase(PotterBooks.PotterBook7, Result = 8)]
        public decimal OneBook_Cost_8(PotterBooks book)
        {
            card.Add(new PotterBook(book));
            return card.GetTotal();
        }

        [Test]
        [TestCase(PotterBooks.PotterBook1, Result = 16)]
        [TestCase(PotterBooks.PotterBook2, Result = 16)]
        [TestCase(PotterBooks.PotterBook3, Result = 16)]
        [TestCase(PotterBooks.PotterBook4, Result = 16)]
        [TestCase(PotterBooks.PotterBook5, Result = 16)]
        [TestCase(PotterBooks.PotterBook6, Result = 16)]
        [TestCase(PotterBooks.PotterBook7, Result = 16)]
        public decimal TwoSameBooks_Cost_16(PotterBooks book)
        {
            card.Add(new PotterBook(book));
            card.Add(new PotterBook(book));
            return card.GetTotal();
        }

        [Test]
        [TestCase(PotterBooks.PotterBook1, Result = 56)]
        [TestCase(PotterBooks.PotterBook2, Result = 56)]
        [TestCase(PotterBooks.PotterBook3, Result = 56)]
        [TestCase(PotterBooks.PotterBook4, Result = 56)]
        [TestCase(PotterBooks.PotterBook5, Result = 56)]
        [TestCase(PotterBooks.PotterBook6, Result = 56)]
        [TestCase(PotterBooks.PotterBook7, Result = 56)]
        public decimal SevenSameBooks_Cost_56(PotterBooks book)
        {
            card.Add(new PotterBook(book));
            card.Add(new PotterBook(book));
            card.Add(new PotterBook(book));
            card.Add(new PotterBook(book));
            card.Add(new PotterBook(book));
            card.Add(new PotterBook(book));
            card.Add(new PotterBook(book));
            return card.GetTotal();
        }
    }
}
