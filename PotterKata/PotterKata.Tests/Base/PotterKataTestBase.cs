using NUnit.Framework;
using PotterKata.Card.Concrete;
using PotterKata.Card.Interface;

namespace PotterKata.Tests.Base
{
    /// <summary>
    /// Base cart test class
    /// </summary>
    public class PotterKataTestBase
    {
        protected ICard card;

        [SetUp]
        public void TestInit()
        {
            card = new BookCard();
        }
    }
}
