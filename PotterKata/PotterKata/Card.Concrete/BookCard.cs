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
            return 0;
        }
    }
}
