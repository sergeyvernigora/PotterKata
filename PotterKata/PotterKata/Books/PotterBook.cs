namespace PotterKata.Books
{
    /// <summary>
    /// The Harry potter series book.
    /// </summary>
    public class PotterBook : IBook
    {
        private const decimal BookFixedCost = 8;
        private readonly PotterBooks _potterBookEnum;

        public PotterBook(PotterBooks potterBookEnum)
        {
            _potterBookEnum = potterBookEnum;
        }

        /// <summary>
        ///  Unique book identifier
        /// </summary>
        public PotterBooks ID
        {
            get { return _potterBookEnum; }
        }

        /// <summary>
        /// Book cost
        /// </summary>
        public decimal Cost
        {
            get { return BookFixedCost; }
        }

        /// <summary>
        /// Book name
        /// </summary>
        public string Name
        {
            get { return string.Format("The {0}.", ID); }
        }
    }
}
