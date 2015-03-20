using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotterKata.Books;
using PotterKata.Card.Interface;

namespace PotterKata.Card.Concrete
{
    /// <summary>
    /// The book card
    /// </summary>
    public class BookCard : ICard
    {
        private readonly List<IBook> _books;

        private const int TwoBooks = 2;
        private const int ThreeBooks = 3;
        private const int ForeBooks = 4;
        private const int FiveBooks = 5;
        private const int SixBook = 6;
        private const int SevenBooks = 7;

        private const int Percent0 = 0;
        private const int Percent5 = 5;
        private const int Percent10 = 10;
        private const int Percent15 = 15;
        private const int Percent20 = 20;
        private const int Percent25 = 25;
        private const int Percent30 = 30;

        /// <summary>
        /// ctor
        /// </summary>
        public BookCard()
        {
            _books = new List<IBook>();
        }

        /// <summary>
        /// Add book to the card.
        /// </summary>
        /// <param name="potterBook"></param>
        public void Add(PotterBook potterBook)
        {
            _books.Add(potterBook);
        }

        /// <summary>
        /// Calculate card total
        /// </summary>
        /// <returns></returns>
        public decimal GetTotal()
        {
            var total = _books.Sum(x => x.Cost);
            var groups = _books.GroupBy(x => x.ID);
            var discountPercent = GetDiscountPercent(groups.Count());

            decimal discount = groups.Sum(@group => @group.First().Cost * discountPercent / 100);

            return total - discount;
        }


        /// <summary>
        /// Percent depends on 
        /// </summary>
        /// <param name="sameBooksCount"></param>
        /// <returns></returns>
        private int GetDiscountPercent(int sameBooksCount)
        {
            switch (sameBooksCount)
            {
                case TwoBooks:
                    return Percent5;
                case ThreeBooks:
                    return Percent10;
                case ForeBooks:
                    return Percent15;
                case FiveBooks:
                    return Percent20;
                case SixBook:
                    return Percent25;
                case SevenBooks:
                    return Percent30;
                default:
                    return Percent0;
            }
        }
    }
}
