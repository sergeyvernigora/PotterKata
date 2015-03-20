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
