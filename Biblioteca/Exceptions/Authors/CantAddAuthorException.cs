namespace Biblioteca.Exceptions.Authors
{
    public class CantAddAuthorException : Exception
    {
        public  CantAddAuthorException() : base("Impossibile aggiungere il l'autore")
        {
        }
    }
}
