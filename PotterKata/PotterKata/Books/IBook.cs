namespace PotterKata.Books
{
    /// <summary>
    /// Book interface
    /// </summary>
    public interface IBook
    {
        PotterBooks ID { get; }
        decimal Cost { get; }
        string Name { get; }
    }
}
