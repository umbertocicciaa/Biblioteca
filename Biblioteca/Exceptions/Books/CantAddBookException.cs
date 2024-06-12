namespace Biblioteca.Exceptions.Books
{
    public class CantAddBookException : Exception
    {
        public CantAddBookException() : base("Impossibile aggiungere il libro.")
        {
        }
    }
}
