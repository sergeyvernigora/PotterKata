using PotterKata.Books;

namespace PotterKata.Card.Interface
{
    /// <summary>
    /// Card interface
    /// </summary>
    public interface ICard
    {
        void Add(PotterBook potterBook);

        decimal GetTotal();
    }
}
