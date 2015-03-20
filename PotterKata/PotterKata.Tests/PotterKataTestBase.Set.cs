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
    /// Different combinations of books
    /// </summary>
    [TestFixture]
    public class PotterKataTestSets : PotterKataTestBase
    {
        [Test]
        public void One_Copy_Of_FirstBook_and_Two_Copy_Of_Second_Book_Discount5()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook2));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 23.2);
        }

        [Test]
        [TestCase(PotterBooks.PotterBook1, PotterBooks.PotterBook2, Result = 31.2)]
        [TestCase(PotterBooks.PotterBook2, PotterBooks.PotterBook5, Result = 31.2)]
        public decimal TwoPair_Discount5(PotterBooks book1, PotterBooks book2)
        {
            card.Add(new PotterBook(book1));
            card.Add(new PotterBook(book2));

            card.Add(new PotterBook(book1));
            card.Add(new PotterBook(book2));

            return card.GetTotal();
        }

        [Test]
        [TestCase(PotterBooks.PotterBook1, PotterBooks.PotterBook2, Result = 47.2)]
        [TestCase(PotterBooks.PotterBook2, PotterBooks.PotterBook5, Result = 47.2)]
        public decimal ThreePair_Discount5(PotterBooks book1, PotterBooks book2)
        {
            card.Add(new PotterBook(book1));
            card.Add(new PotterBook(book2));

            card.Add(new PotterBook(book1));
            card.Add(new PotterBook(book2));

            card.Add(new PotterBook(book1));
            card.Add(new PotterBook(book2));

            return card.GetTotal();
        }

        [Test]
        public void TwoAdd_On_Copy_Of_FirstBook_and_Two_Copy_Of_Second_Book_Discount5()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook2));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 31.2);
        }

        [Test]
        public void ForBooks_TwoSame_Discount10()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook3));
            card.Add(new PotterBook(PotterBooks.PotterBook4));
            card.Add(new PotterBook(PotterBooks.PotterBook5));
            card.Add(new PotterBook(PotterBooks.PotterBook5));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 29.6);
        }

        [Test]
        public void AllSet_Plus_OneDuplicate()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook3));
            card.Add(new PotterBook(PotterBooks.PotterBook4));
            card.Add(new PotterBook(PotterBooks.PotterBook5));
            card.Add(new PotterBook(PotterBooks.PotterBook6));
            card.Add(new PotterBook(PotterBooks.PotterBook7));


            card.Add(new PotterBook(PotterBooks.PotterBook7));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 47.2);
        }

        [Test]
        public void AllSet_Plus_ThreeDuplicate()
        {
            card.Add(new PotterBook(PotterBooks.PotterBook1));
            card.Add(new PotterBook(PotterBooks.PotterBook2));
            card.Add(new PotterBook(PotterBooks.PotterBook3));
            card.Add(new PotterBook(PotterBooks.PotterBook4));
            card.Add(new PotterBook(PotterBooks.PotterBook5));
            card.Add(new PotterBook(PotterBooks.PotterBook6));
            card.Add(new PotterBook(PotterBooks.PotterBook7));

            card.Add(new PotterBook(PotterBooks.PotterBook1));

            card.Add(new PotterBook(PotterBooks.PotterBook3));

            card.Add(new PotterBook(PotterBooks.PotterBook7));

            var cost = card.GetTotal();
            Assert.AreEqual(cost, 63.2);
        }
    }
}
