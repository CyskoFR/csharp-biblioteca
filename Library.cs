public class Library
{
    List<User> RegisteredUsers = new List<User>();

    List<Dvd> Dvds = new List<Dvd>();

    List<Book> Books = new List<Book>();

    // add/remove user
    public void AddUser(User user)
    {
        RegisteredUsers.Add(user);
    }
    public void RemoveUser(User user)
    {
        RegisteredUsers.Remove(user);
    }

    // add/remove dvd
    public void AddMovie(Dvd dvd)
    {
        Dvds.Add(dvd);
    }
    public void RemoveDvd(Dvd dvd)
    {
        Dvds.Remove(dvd);
    }

    // add/remove book
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }
}